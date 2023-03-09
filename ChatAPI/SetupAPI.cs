using Db;

// Sets API connections and routes for app
namespace RouteSetter {
    class SetupAPI
    {
        private DbConnection DbConn;

        public SetupAPI(ref WebApplication app, string DBConnURL)
        {
            this.SetRoutes(ref app);
            
            DbConn = new DbConnection(DBConnURL);
        }

        private void SetRoutes(ref WebApplication app) 
        {
            app.MapGet("/testing", () => "Hello");
        }

    }
}
