using GeopagosChallenge.Domain.Entities;
using LiteDB;

namespace GeopagosChallenge.Infraestructure.Database
{
    public class LiteDbContext
    {
        private const string DatabasePath = "tournament.db";
        private readonly LiteDatabase _database;

        public LiteDbContext()
        {
            _database = new LiteDatabase(DatabasePath);
        }

        public ILiteCollection<Tournament> Tournaments => _database.GetCollection<Tournament>("tournaments");

        public void Dispose()
        {
            _database?.Dispose();
        }
    }
}
