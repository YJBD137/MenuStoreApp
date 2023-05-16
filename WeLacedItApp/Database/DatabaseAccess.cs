using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WeLacedItApp.Database
{
    public class DatabaseAccess
    {

        //Made by Yuan Jason B. Dimayuga

        private string user;

        SqlConnection conn;
        SqlCommand cmd;
        public string? ExecutedCode, Msg;
        public bool isConnected = false;

        public DatabaseAccess(string UserId, string Password)
        {

            user = @"Data Source = DESKTOP-0I7BTFQ; Initial Catalog = Project_Inv; User Id = " + UserId + "; Password = " + Password + ";";
            conn = new SqlConnection(user);
            cmd = new SqlCommand(user, conn);

            cmd.CommandTimeout = 60;

            try
            {

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    isConnected = true;
                    Msg = "\n------\n" + "Connected" + "\n------\n";
                }

            }
            catch (Exception e)
            {
                ExecutedCode = "Error: " + e;
                Msg = "Process Falied";
            }
            finally { conn.Close(); }
        }

        public void Execute(string Code)
        {
            cmd.CommandText = Code;

            try
            {

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {

                    cmd.ExecuteScalar();
                    ExecutedCode = "Completed: \n------\n" + cmd.CommandText + "\n------\n";
                    Msg = "Process Complete";
                }

            }
            catch (Exception e)
            {
                ExecutedCode = "Error: " + e;
                Msg = "Process Falied";
            }
            finally { conn.Close(); }
        }

        public string[]? SColReader(string Code) //needs fixing
        {
            string[] result = { };
            cmd.CommandText = Code;

            try
            {

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {

                    SqlDataReader col = cmd.ExecuteReader();

                    for (int i = 1; col.Read(); i++)
                    {

                        result = new string[col.FieldCount];
                        result.SetValue(col, i - 1);

                    }

                    ExecutedCode = "Completed: \n------\n" + cmd.CommandText + "\n------\n";
                    Msg = "Process Complete";

                    return result;
                }

            }
            catch (Exception e)
            {
                ExecutedCode = "Error: " + e;
                Msg = "Process Falied";
            }
            finally { conn.Close(); }

            return result;

        }

        // Setup Methods

        public class Setup : DatabaseAccess
        {
            public Setup(string UserId, string Password) : base(UserId, Password) { }


            public void Query(string Query, string Values)
            {
                string[] c = Values.Split(',');

                try
                {
                    if (c.Length > 0)
                    {

                        switch (Query)
                        {

                            case "AddEmployee":

                                AddEmployee(c[0], c[1], c[2], c[3], c[4], c[5], c[6], c[7], c[8]);

                                break;

                            case "AddProduct":

                                AddProduct(c[0], c[1], c[2], c[3], c[4], c[5], c[6], c[7]);

                                break;

                            case "AddPosition":

                                AddPosition(c[0]);

                                break;

                            case "AddPayMethod":

                                AddPayMethod(c[0]);

                                break;

                            case "AddConstgnor":

                                AddConstgnor(c[0], c[1], c[2], c[3]);

                                break;


                            case "AddSales":

                                AddSales(c[0], c[1], c[2], c[3], c[4], c[5], c[6]);

                                break;

                            default:

                                throw new NotAQueryException();

                        }

                    }
                    else
                    {
                        throw new SqlNullValueException();
                    }

                }


                catch (Exception e)
                {
                    ExecutedCode = "Error: " + e;
                    Msg = "Process Falied";
                }
                finally { conn.Close(); }



            }



            public void AddConstgnor(string ConstgnorNAME, string ConstgnorADDRESS, string cellNUMBER, string EmailADDRESS)
            {


                string code =
                        "INSERT INTO CONSIGNORS (" +
                        "ConstgnorNAME," +
                        "ConstgnorADDRESS," +
                        "cellNUMBER," +
                        "EmailADDRESS" +
                        ")VALUES(" +
                        "'" + ConstgnorNAME + "'," +
                        "'" + ConstgnorADDRESS + "'," +
                        "'" + cellNUMBER + "'," +
                        "'" + EmailADDRESS + "'" +
                        ");";

                Execute(code);
            }

            public void AddPayMethod(string payTYPE)
            {

                string code =
                        "INSERT INTO PayMETHOD (" +
                        "payTYPE" +
                        ")VALUES(" +
                        "'" + payTYPE + "'" +
                        ");";

                Execute(code);
            }

            public void AddPosition(string positionNAME)
            {


                string code =
                        "INSERT INTO POSTION (" +
                        "positionNAME," +
                        ")VALUES(" +
                        "'" + positionNAME + "'" +
                        ");";

                Execute(code);
            }

            public void AddProduct(string CONSIGNOR_ID, string SKU, string productNAME, string UNIT, string PRICE, string OnHAND_QTY, string THRESHOLD, string STATUS_ID)
            {



                string code =
                        "INSERT INTO INVENTORY (" +
                        "CONSIGNOR_ID," +
                        "SKU," +
                        "productNAME," +
                        "UNIT," +
                        "PRICE," +
                        "OnHAND_QTY," +
                        "THRESHOLD," +
                        "STATUS_ID" +
                        ")VALUES(" +
                        "'" + CONSIGNOR_ID + "'," +
                        "'" + SKU + "'," +
                        "'" + productNAME + "'," +
                        "'" + UNIT + "'," +
                        PRICE + "," +
                        OnHAND_QTY + "," +
                        THRESHOLD + "," +
                        STATUS_ID +
                        ");";

                Execute(code);
            }


            public void AddEmployee(string employeeNAME, string employeeGENDER, string employeeADDRESS, string cellNUMBER, string EmailADDRESS, string employeePASSWORD, string DATE_HIRED, string SALARYperMonth, string POSITION_ID)
            {
                string code;

                if (DATE_HIRED.ToUpper().Equals("NULL"))
                {
                    code =
                            "INSERT INTO EMPLOYEE (" +
                            "employeeNAME," +
                            "employeeGENDER," +
                            "employeeADDRESS," +
                            "cellNUMBER," +
                            "EmailADDRESS," +
                            "employeePASSWORD," +
                            "DATE_HIRED," +
                            "SALARYperMonth," +
                            "POSITION_ID" +
                            ")VALUES(" +
                            "'" + employeeNAME + "'," +
                            "'" + employeeGENDER + "'," +
                            "'" + employeeADDRESS + "'," +
                            "'" + cellNUMBER + "'," +
                            "'" + EmailADDRESS + "'," +
                            "'" + employeePASSWORD + "'," +
                            "" + DATE_HIRED + "," +
                            SALARYperMonth + "," +
                            POSITION_ID +
                            ");";
                }
                else
                {
                    code =
                            "INSERT INTO EMPLOYEE (" +
                            "employeeNAME," +
                            "employeeGENDER," +
                            "employeeADDRESS," +
                            "cellNUMBER," +
                            "EmailADDRESS," +
                            "employeePASSWORD," +
                            "DATE_HIRED," +
                            "SALARYperMonth," +
                            "POSITION_ID" +
                            ")VALUES(" +
                            "'" + employeeNAME + "'," +
                            "'" + employeeGENDER + "'," +
                            "'" + employeeADDRESS + "'," +
                            "'" + cellNUMBER + "'," +
                            "'" + EmailADDRESS + "'," +
                            "'" + employeePASSWORD + "'," +
                            "{d'" + DATE_HIRED + "'}," +
                            SALARYperMonth + "," +
                            POSITION_ID +
                            ");";
                }

                Execute(code);
            }

        }

        //end User Methods:

        //make a method for multiple unique item sales   

        public void AddSales(string INVENTORY_ID, string QUANTITY, string SALES_DATE, string CUSTOMER_ID, string EMPLOYEE_ID, string PAYMENT_ID, string paidAMOUNT)
        {
            int Tranaction_ID = 1;

            cmd.CommandText =
                "SELECT MAX(Tranaction_ID) " +
                "FROM SALES";

            try
            {

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {

                    Tranaction_ID = cmd.ExecuteReader().GetInt32(1);
                    ExecutedCode = "Completed: \n------\n" + cmd.CommandText + "\n------\n" + "\n------\n";
                    Msg = "Process Complete";

                }

            }
            catch (SqlNullValueException s)
            {

                ExecutedCode = "Error: " + s;
                Msg = "Tranaction_ID is now (1)";

            }
            catch (Exception e)
            {
                ExecutedCode = "Error: " + e;
                Msg = "Process Falied";
            }
            finally { conn.Close(); }

            string code1 =
                    "INSERT INTO SALES (" +
                    "Tranaction_ID ," +
                    "INVENTORY_ID ," +
                    "QUANTITY ," +
                    "SALES_DATE," +
                    "CUSTOMER_ID," +
                    "EMPLOYEE_ID ," +
                    "PAYMENT_ID," +
                    "paidAMOUNT," +
                    ")VALUES(" +
                    Tranaction_ID + "," +
                    INVENTORY_ID + "," +
                    QUANTITY + "," +
                    "'" + SALES_DATE + "'," +
                    CUSTOMER_ID + "," +
                    EMPLOYEE_ID + "," +
                    PAYMENT_ID + "," +
                    paidAMOUNT + "," +
                    ");" +

                    "INSERT INTO FINANCES (" +
                    "payTYPE" +
                    ")VALUES(" +
                    "'" + INVENTORY_ID + "'," +
                    ");" +

                    "UPDATE INVENTORY" +
                    "SET OnHAND_QTY = OnHAND_QTY - " + QUANTITY +
                    "WHERE INVENTORY_ID = " + INVENTORY_ID;

            Execute(code1);

        }


        class NotAQueryException : Exception
        {
            public NotAQueryException()
            {

                Console.Write("NotAQueryException: Not a valid SQL Query in this database.");

            }
        }


    }
}
