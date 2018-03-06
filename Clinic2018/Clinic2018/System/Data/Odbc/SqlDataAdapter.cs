using System.Data.SqlClient;

namespace System.Data.Odbc
{
    internal class SqlDataAdapter
    {
        private SqlConnection conn;
        private string v;

        public SqlDataAdapter(string v, SqlConnection conn)
        {
            this.v = v;
            this.conn = conn;
        }

        internal void Fill(DataSet ds)
        {
            throw new NotImplementedException();
        }
    }
}