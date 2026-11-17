using System.Collections.Generic;

namespace Proyecto_Salon_de_Eventos.Repository
{
    // Interfaz genérica para el patrón Repository
    public interface IRepository<T>
    {
        // Agrega una nueva entidad a la colección
        void Add(T entity);

        // Obtiene la lista completa de entidades
        IEnumerable<T> GetAll();

        // Busca una entidad por su identificador único (devuelve null si no existe)
        T? GetById(int id);

        // Modifica los datos de una entidad existente
        bool Update(T entity);

        // Elimina una entidad según su ID
        bool Remove(int id);
    }
}

