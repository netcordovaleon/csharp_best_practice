
using System.Threading.Tasks.Dataflow;

namespace BestPractices.DesignPatterns.Structures
{

    public interface IReadFacade<T> {
        T GetById(int id);
    }

    public interface ISaveFacade<T>
    {
        T Save(T entity);
    }

    public class GenericDBSQLOperation<T> : IReadFacade<T>, ISaveFacade<T>
    {
        public T GetById(int id)
        {
            //Conectaran a la BD - ORM
            //(JAVA JPA, Spring Data, Hibernate)
            // .NET - EntityFramework
            T result = default(T);
            return result;
        }

        public T Save(T entity)
        {
            //Conectaran a la BD - ORM
            //(JAVA JPA, Spring Data, Hibernate)
            // .NET - EntityFramework
            return entity;
        }
    }

    //USO DE FACADE
    public class Alumno {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNac { get; set; }
    }

    public class Docente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class Auxiliar
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class AlumnoRepository : GenericDBSQLOperation<Alumno>, IReadFacade<Alumno>, ISaveFacade<Alumno>
    {


        public void GenerateReport() { 
        
            //JoinBlock, left join , right join, outer join
        }

    }

    public class DocenteRepository : GenericDBSQLOperation<Docente>, IReadFacade<Docente>
    {
    }

    public class AuxiliarRepository : GenericDBSQLOperation<Auxiliar>, ISaveFacade<Auxiliar>
    {
    }

}
