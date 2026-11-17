using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;
using Proyecto_Salon_de_Eventos.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_Salon_de_Eventos.Service
{
    public class PdfExportService
    {
        public void ExportarPresupuestoAPdf(Presupuesto presupuesto)
        {
            if (presupuesto == null)
            {
                throw new ArgumentNullException(nameof(presupuesto), "El presupuesto no puede ser nulo.");
            }

            SaveFileDialog selectorUbicacion = new SaveFileDialog();
            selectorUbicacion.Filter = "Archivo PDF (*.pdf)|*.pdf";
            selectorUbicacion.Title = "Guardar Comprobante PDF";
            selectorUbicacion.FileName = "Presupuesto_" + presupuesto.Id + "_" + presupuesto.Cliente.Apellido + ".pdf";

            if (selectorUbicacion.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = selectorUbicacion.FileName;

                PdfDocument documento = new PdfDocument();
                documento.Info.Title = "Presupuesto Nro " + presupuesto.Id;

                PdfPage pagina = documento.AddPage();
                XGraphics grafico = XGraphics.FromPdfPage(pagina);

                XFont fuenteEmpresa = new XFont("Arial", 14, XFontStyle.Bold);
                XFont fuenteDocTipo = new XFont("Arial", 16, XFontStyle.Bold);
                XFont fuenteSubtitulo = new XFont("Arial", 10, XFontStyle.Bold);
                XFont fuenteTexto = new XFont("Arial", 9, XFontStyle.Regular);
                XFont fuenteTextoBold = new XFont("Arial", 9, XFontStyle.Bold);
                XFont fuenteTotalBold = new XFont("Arial", 12, XFontStyle.Bold);

                XPen lapizGris = new XPen(XColors.Gray, 0.75);
                XPen lapizNegro = new XPen(XColors.Black, 1.0);

                double margenX = 40.0;
                double anchoPagina = pagina.Width.Point - 80.0;
                double posicionY = 40.0;

                grafico.DrawString("Eventos Miramar", fuenteEmpresa, XBrushes.DarkBlue, new XPoint(margenX, posicionY + 5.0));

                double anchoCuadroX = 30.0;
                double altoCuadroX = 25.0;
                double posXCuadro = (pagina.Width.Point - anchoCuadroX) / 2.0;
                XRect rectLetra = new XRect(posXCuadro, posicionY, anchoCuadroX, altoCuadroX);
                grafico.DrawRectangle(lapizNegro, rectLetra);
                grafico.DrawString("X", fuenteDocTipo, XBrushes.Black, new XPoint(rectLetra.X + 8.0, rectLetra.Y + 18.0));

                string textoFechaEmision = "Fecha Emisión: " + presupuesto.FechaPresupuesto.ToString("dd/MM/yyyy");
                double anchoTextoFecha = grafico.MeasureString(textoFechaEmision, fuenteTexto).Width;
                double posXFecha = (margenX + anchoPagina) - anchoTextoFecha;
                grafico.DrawString(textoFechaEmision, fuenteTexto, XBrushes.Black, new XPoint(posXFecha, posicionY + 5.0));

                posicionY += 35.0;

                grafico.DrawString("Dirección: Av. Costanera 1000 - Miramar", fuenteTexto, XBrushes.Black, new XPoint(margenX, posicionY));
                posicionY += 15.0;
                grafico.DrawString("CUIT: 30-12345678-9 | IVA Responsable Inscripto", fuenteTexto, XBrushes.Black, new XPoint(margenX, posicionY));

                posicionY += 35.0;

                grafico.DrawString("PRESUPUESTO Nro: " + presupuesto.Id, fuenteDocTipo, XBrushes.DarkSlateGray, new XPoint(margenX, posicionY));
                posicionY += 10.0;

                grafico.DrawLine(lapizNegro, margenX, posicionY, margenX + anchoPagina, posicionY);
                posicionY += 15.0;

                grafico.DrawString("Cliente: " + presupuesto.Cliente.Nombre + " " + presupuesto.Cliente.Apellido, fuenteTextoBold, XBrushes.Black, new XPoint(margenX, posicionY));
                grafico.DrawString("Fecha del Evento: " + presupuesto.FechaEvento.ToString("dd/MM/yyyy"), fuenteTexto, XBrushes.Black, new XPoint(margenX + 250.0, posicionY));
                posicionY += 15.0;

                grafico.DrawString("DNI / Tel: " + presupuesto.Cliente.Dni + " / " + presupuesto.Cliente.Telefono, fuenteTexto, XBrushes.Black, new XPoint(margenX, posicionY));
                grafico.DrawString("Salón Asignado: " + presupuesto.Salon.Nombre + " (" + presupuesto.Salon.Localidad + ")", fuenteTexto, XBrushes.Black, new XPoint(margenX + 250.0, posicionY));
                posicionY += 20.0;

                grafico.DrawLine(lapizGris, margenX, posicionY, margenX + anchoPagina, posicionY);
                posicionY += 15.0;

                XRect rectTablaHeader = new XRect(margenX, posicionY, anchoPagina, 20.0);
                grafico.DrawRectangle(XBrushes.LightGray, rectTablaHeader);

                string textoHeaderSubtotal = "Subtotal";
                double anchoHeaderSubtotal = grafico.MeasureString(textoHeaderSubtotal, fuenteSubtitulo).Width;
                double xSubtotalColumna = (margenX + anchoPagina) - anchoHeaderSubtotal - 10.0;

                grafico.DrawString("Cantidad / Detalle", fuenteSubtitulo, XBrushes.Black, new XPoint(margenX + 5.0, posicionY + 14.0));
                grafico.DrawString(textoHeaderSubtotal, fuenteSubtitulo, XBrushes.Black, new XPoint(xSubtotalColumna, posicionY + 14.0));

                posicionY += 40.0;

                string precioSalonStr = "$" + presupuesto.Salon.Precio.ToString("N2");
                double anchoPrecioSalon = grafico.MeasureString(precioSalonStr, fuenteTexto).Width;
                grafico.DrawString("1 - Alquiler de Salón: " + presupuesto.Salon.Nombre, fuenteTexto, XBrushes.Black, new XPoint(margenX + 5.0, posicionY));
                grafico.DrawString(precioSalonStr, fuenteTexto, XBrushes.Black, new XPoint((margenX + anchoPagina) - anchoPrecioSalon, posicionY));
                posicionY += 18.0;

                foreach (ItemMenu itemMenu in presupuesto.Menus)
                {
                    string textoMenu = itemMenu.Cantidad + " x Menú: " + itemMenu.Item.Nombre + " ($" + itemMenu.Item.Precio.ToString("N2") + " c/u)";
                    decimal subtotalMenu = itemMenu.CalcularSubtotal();
                    string precioMenuStr = "$" + subtotalMenu.ToString("N2");
                    double anchoPrecioMenu = grafico.MeasureString(precioMenuStr, fuenteTexto).Width;

                    grafico.DrawString(textoMenu, fuenteTexto, XBrushes.Black, new XPoint(margenX + 5.0, posicionY));
                    grafico.DrawString(precioMenuStr, fuenteTexto, XBrushes.Black, new XPoint((margenX + anchoPagina) - anchoPrecioMenu, posicionY));
                    posicionY += 18.0;
                }

                foreach (ServicioAdicional servicio in presupuesto.ServiciosAdicionales)
                {
                    string precioServicioStr = "$" + servicio.Precio.ToString("N2");
                    double anchoPrecioServicio = grafico.MeasureString(precioServicioStr, fuenteTexto).Width;

                    grafico.DrawString("1 - Servicio Adicional: " + servicio.Nombre, fuenteTexto, XBrushes.Black, new XPoint(margenX + 5.0, posicionY));
                    grafico.DrawString(precioServicioStr, fuenteTexto, XBrushes.Black, new XPoint((margenX + anchoPagina) - anchoPrecioServicio, posicionY));
                    posicionY += 18.0;
                }

                posicionY += 10.0;
                grafico.DrawLine(lapizGris, margenX, posicionY, margenX + anchoPagina, posicionY);
                posicionY += 20.0;

                grafico.DrawString("Duración estimada del evento: " + presupuesto.Duracion + " horas", fuenteTexto, XBrushes.Black, new XPoint(margenX, posicionY));
                grafico.DrawString("Total Invitados: " + presupuesto.CalcularTotalInvitados(), fuenteTexto, XBrushes.Black, new XPoint(margenX, posicionY + 15.0));

                grafico.DrawString("TOTAL GENERAL:", fuenteSubtitulo, XBrushes.Black, new XPoint(margenX + 250.0, posicionY));
                string totalStr = "$" + presupuesto.CalcularTotal().ToString("N2");
                double anchoTotal = grafico.MeasureString(totalStr, fuenteTotalBold).Width;
                grafico.DrawString(totalStr, fuenteTotalBold, XBrushes.DarkRed, new XPoint((margenX + anchoPagina) - anchoTotal, posicionY));

                documento.Save(rutaArchivo);
                documento.Close();

                MessageBox.Show("¡Comprobante PDF generado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}