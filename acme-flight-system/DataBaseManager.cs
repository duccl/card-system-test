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
            IfDataBaseNotExistsCreateItAndCreateTableVoo();
        }

        private void CreateTableVoo()
        {
            string query = "CREATE TABLE TB_VOO (ID_VOO INT PRIMARY KEY,DATA_VOO DATETIME,CUSTO NUMERIC(10,2),DISTANCIA INT,CAPTURA CHAR(1),NIVEL_DOR INT,CHECK (CAPTURA = 'S' OR CAPTURA = 'N'),CHECK (NIVEL_DOR >= 0 AND NIVEL_DOR <= 10));";
            using (var database_connection = GetDbConnection())
            {
                database_connection.Execute(query);
            }
        }

        private void IfDataBaseNotExistsCreateItAndCreateTableVoo()
        {
            string connection_string_sqlite_file = LoadDataBaseConnectionString().Split(';')[0].Split('=')[1];
            if (!System.IO.File.Exists(connection_string_sqlite_file)) 
            {
                System.IO.File.Create(connection_string_sqlite_file).Close();
                CreateTableVoo();
            }
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
            string query = "insert into TB_VOO values " +
                        "(@ID_VOO,@Data_voo,@Custo,@Distancia,@Captura,@Nivel_dor)";
            using (var database_connection = GetDbConnection())
            {
                await Task.Run( () => database_connection.Execute(query, novo_voo));
                populate_grid_view_callback();
            }
        }

        public async Task DeleteVoo(VooModel voo,System.Action populate_grid_view_callback)
        {
            
            string query = "DELETE FROM TB_VOO WHERE ID_VOO= @ID_VOO";
            using (var database_connection = GetDbConnection())
            {
                await Task.Run(() => database_connection.Execute(query, voo));
                populate_grid_view_callback();
            }
        }

        public async Task UpdateVoo(VooModel novo_voo, System.Action populate_grid_view_callback)
        {
            string query = "UPDATE TB_VOO SET DATA_VOO=@Data_voo, CUSTO=@Custo, DISTANCIA=@Distancia, CAPTURA=@Captura, NIVEL_DOR=@Nivel_dor WHERE ID_VOO= @ID_VOO";
            using (var database_connection = GetDbConnection())
            {
                await Task.Run(() => database_connection.Execute(query, novo_voo));
                populate_grid_view_callback();
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
