using OOP.FinalTerm.Exam.Model;
using OOP.FinalTerm.Exam.Utils;
using SQLite;

namespace OOP.FinalTerm.Exam.Repository
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly ISQLiteConnection _dbConnection;
        public DirectorRepository()
        {
            _dbConnection = new SQLiteConnection(DatabaseHelper.GetDatabasePath());
            _dbConnection.CreateTable<DirectorModel>();
        }
        /// <summary>
        /// Adds a new director to the database.
        /// </summary>
        /// <param name="director">The director object to add</param>
        public void AddDirector(DirectorModel director)
        {
            _dbConnection.Insert(director);
        }
        /// <summary>
        /// Retrieves all directors from the database.
        /// </summary>
        /// <returns>List of all directors</returns>
        public List<DirectorModel> GetAllDirectors()
        {
            return _dbConnection.Table<DirectorModel>().ToList();
        }
        /// <summary>
        /// Retrieves a specific director by their ID.
        /// </summary>
        /// <param name="id">The director ID to search for</param>
        /// <returns>Director object if found, null otherwise</returns>
        public DirectorModel GetDirectorById(int id)
        {  
           return _dbConnection.Find<DirectorModel>(id);
        }
    }
}