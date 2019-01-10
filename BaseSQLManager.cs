 public class BaseSQLManager
    {
        public string connectionString = string.Empty;
        //public BaseSQLManager()
        //{
        //    //connectionString = ConfigurationManager.ConnectionStrings["CoonectionString"].ConnectionString;
        //}
          
        #region GetField
        public static String GetField(IDataReader rs, String fieldname)
        {
            int idx = rs.GetOrdinal(fieldname);
            if (rs.IsDBNull(idx))
            {
                return String.Empty;
            }
            return rs.GetString(idx);
        }



        public static bool GetFieldBool(IDataReader rs, String fieldname)
        {
            int idx = rs.GetOrdinal(fieldname);
            if (rs.IsDBNull(idx))
            {
                return false;
            }

            String s = rs[fieldname].ToString();

            return (s.Equals("TRUE", StringComparison.InvariantCultureIgnoreCase) ||
                    s.Equals("YES", StringComparison.InvariantCultureIgnoreCase) ||
                    s.Equals("1", StringComparison.InvariantCultureIgnoreCase));
        }

        public static String GetFieldGUID(IDataReader rs, String fieldname)
        {
            int idx = rs.GetOrdinal(fieldname);
            if (rs.IsDBNull(idx))
            {
                return String.Empty;
            }
            return rs.GetGuid(idx).ToString();
        }

        public static Guid GetFieldGUID2(IDataReader rs, String fieldname)
        {
            int idx = rs.GetOrdinal(fieldname);
            if (rs.IsDBNull(idx))
            {
                return new Guid("00000000000000000000000000000000");
            }
            return rs.GetGuid(idx);
        }

        public static Byte GetFieldByte(IDataReader rs, String fieldname)
        {
            int idx = rs.GetOrdinal(fieldname);
            if (rs.IsDBNull(idx))
            {
                return 0;
            }
            return rs.GetByte(idx);
        }

        public static int GetFieldInt(IDataReader rs, String fieldname)
        {
            int idx = rs.GetOrdinal(fieldname);
            if (rs.IsDBNull(idx))
            {
                return 0;
            }
            return rs.GetInt32(idx);
        }

        public static short GetFieldShort(IDataReader rs, String fieldname)
        {
            int idx = rs.GetOrdinal(fieldname);
            if (rs.IsDBNull(idx))
            {
                return 0;
            }
            short ni;
            short.TryParse(rs[idx].ToString(), NumberStyles.Integer, Thread.CurrentThread.CurrentUICulture, out ni); // use default locale setting
            return ni;
        }

        public static int GetFieldTinyInt(IDataReader rs, String fieldname)
        {
            int idx = rs.GetOrdinal(fieldname);
            if (rs.IsDBNull(idx))
            {
                return 0;
            }
            int ni;
            System.Int32.TryParse(rs[idx].ToString(), NumberStyles.Integer, Thread.CurrentThread.CurrentUICulture, out ni); // use default locale setting
            return ni;
        }

        public static long GetFieldLong(IDataReader rs, String fieldname)
        {
            int idx = rs.GetOrdinal(fieldname);
            if (rs.IsDBNull(idx))
            {
                return 0;
            }
            return rs.GetInt64(idx);
        }

        public static Single GetFieldSingle(IDataReader rs, String fieldname)
        {
            int idx = rs.GetOrdinal(fieldname);
            if (rs.IsDBNull(idx))
            {
                return 0.0F;
            }
            return (Single)rs.GetDouble(idx); // SQL server seems to fail the GetFloat calls, so we have to do this
        }

        public static Double GetFieldDouble(IDataReader rs, String fieldname)
        {
            int idx = rs.GetOrdinal(fieldname);
            if (rs.IsDBNull(idx))
            {
                return 0.0F;
            }
            return rs.GetDouble(idx);
        }

        public static Decimal GetFieldDecimal(IDataReader rs, String fieldname)
        {
            int idx = rs.GetOrdinal(fieldname);
            if (rs.IsDBNull(idx))
            {
                return System.Decimal.Zero;
            }
            return rs.GetDecimal(idx);
        }
        public static float GetFieldFloat(IDataReader rs, String fieldname)
        {
            int idx = rs.GetOrdinal(fieldname);
            if (rs.IsDBNull(idx))
            {
                return 0;
            }
            return rs.GetFloat(idx);
        }

        public static DateTime GetFieldDateTime(IDataReader rs, String fieldname)
        {
            int idx = rs.GetOrdinal(fieldname);
            if (rs.IsDBNull(idx))
            {
                return System.DateTime.MinValue;
            }
            return Convert.ToDateTime(rs[idx], SqlServerCulture);
        }
        //Ashish Meghpara , 04-03-2013
        public static String GetFieldDateTimeStr(IDataReader rs, String fieldname)
        {
            int idx = rs.GetOrdinal(fieldname);
            if (rs.IsDBNull(idx))
            {
                return String.Empty;
            }
            DateTime Datefrm = Convert.ToDateTime(rs[idx], SqlServerCulture);
            String DateStr = Datefrm.ToString("MM-dd-yyyy");
            return DateStr;
        }
        #endregion
    }
