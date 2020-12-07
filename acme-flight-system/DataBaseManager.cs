using System.Data.SQLite;
using System.Data;
using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using acme_flight_system.Models;

namespace acme_flight_system
{
    class DataBaseManager
    {
        private string database_name;
        public DataBaseManager(string database_name)
        {
            this.database_name = database_name;
        }

        public async Task<List<VooModel>> ResgataTodosRegistrosDeVoos()
        {
            using (var database_connection = GetDbConnection())
            {
                var all_voos = await Task.Run( () => database_connection.Query<VooModel>("select * from TB_VOO"));
                return all_voos.AsList();
            }
        }

        public async Task AdicionaVoo(VooModel novo_voo,System.Action populate_grid_view_callback)
        {
            var flight_exists = await IsFlightAlreadyRegistered(novo_voo);
            if (flight_exists) return;
            string query = "insert into TB_VOO values " +
                        "(@ID_VOO,@Data_voo,@Custo,@Distancia,@Captura,@Nivel_dor)";
            using (var database_connection = GetDbConnection())
            {
                await Task.Run( () => database_connection.Execute(query, novo_voo));
                populate_grid_view_callback();
            }
        }

        public async Task<bool> IsFlightAlreadyRegistered(VooModel voo)
        {
            string query = "SELECT * FROM TB_VOO WHERE ID_VOO = @ID_VOO";
            using (var database_connection = GetDbConnection())
            {
                var filght_rows = await Task.Run(() => database_connection.Execute(query,voo));
                return filght_rows > 0;
            }
        }

        public async Task DeleteVoo(VooModel voo)
        {
            var flight_exists = await IsFlightAlreadyRegistered(voo);
            if (!flight_exists) return;
            string query = "DELETE FROM TB_VOO" +
                           "WHERE ID_VOO= @ID_VOO";
            using (var database_connection = GetDbConnection())
            {
                await Task.Run(() => database_connection.Execute(query, voo));
            }
        }

        public async Task UpdateVoo(VooModel novo_voo)
        {
            string query = "UPDATE TB_VOO SET DATA_VOO=@Data_voo CUSTO=@Custo DISTANCIA=@Distancia CAPTURA=@Captura NIVEL_DOR=@Nivel_dor" +
                           "WHERE ID_VOO=@ID_VOO";
            using (var database_connection = GetDbConnection())
            {
                await Task.Run(() => database_connection.Execute(query, novo_voo));
            }
        }

        public IDbConnection GetDbConnection()
        {
            return new SQLiteConnection(LoadDataBaseConnectionString());
        }

        private string LoadDataBaseConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[database_name].ConnectionString;
        }
    }
}
