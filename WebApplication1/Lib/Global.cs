using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebTentakel.Models;

namespace WebTentakel.Lib
{
    public class Global
    {
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public List<FormMaster> GetFormLayout(string Page)
        {
            var res = new List<FormMaster>();
            try
            {
                conn.ConnectionString = General.Configuration.ToString();
                using (var connection = conn)
                {
                    connection.Open();
                    string sql = "select*from Master_Form where NamaForm='" + Page + "' order by Urutan asc";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.CommandTimeout = 0;
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var d = new FormMaster();
                                Type type = d.GetType();
                                PropertyInfo[] props = type.GetProperties();
                                foreach (var p in props)
                                {
                                    if (null != p && p.CanWrite)
                                    {
                                        if (p.PropertyType.Name.ToString() != "IFormFile" && p.Name != "Result")
                                        {
                                            p.SetValue(d, reader[p.Name].ToString(), null);
                                        }
                                    }
                                }
                                res.Add(d);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }

        public object GetPropValue(object source, string propertyName)
        {
            var property = source.GetType().GetRuntimeProperties().FirstOrDefault(p => string.Equals(p.Name, propertyName, StringComparison.OrdinalIgnoreCase));
            if (property != null)
            {
                if (property.GetValue(source) != null)
                {
                    return property?.GetValue(source);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }
    }
}
