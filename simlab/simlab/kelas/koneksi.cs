﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace simlab.kelas
{
    class koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = USER-PCSQLEXPRESS; Initial Catalog = db_dummy; Integrated Security = True";
            return conn;
        }
    }
}
