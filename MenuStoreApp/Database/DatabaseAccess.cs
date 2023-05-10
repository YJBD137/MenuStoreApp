using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Transactions;

namespace MenuStoreApp.Database
{
    public class DatabaseAccess {

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
            
            try{

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    isConnected = true;
                    Msg = "\n------\n" + "Connected" + "\n------\n";
                }

                }
            catch(Exception e){
                ExecutedCode = "Error: " + e;
                Msg = "Process Falied";
            }
            finally{conn.Close();}
        }

        public void Execute(String Code)
        {
            cmd.CommandText = Code;

            try
            {

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {

                    cmd.ExecuteScalar();
                    ExecutedCode = ("Completed: \n------\n" + cmd.CommandText + "\n------\n");
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

        // Setup Methods

        public class Setup : DatabaseAccess 
        {
            public Setup(string UserId, string Password) : base(UserId, Password) { }
            

            public void Query(String Query, String Values)
            {
                string[] c = Values.Split(',');

                try
                {
                        if (c.Length > 0)
                        {

                        switch (Query)
                        {

                            case "AddEmployee":

                                AddEmployee(c[0], c[1], c[2], c[3], c[4], c[5], c[6], c[7], c[8]); break;

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

                            case "AddCustomer":

                                AddCustomer(c[0], c[1], c[2], c[3]);

                                break;

                            case "AddSales":

                                AddSales(c[0], c[1], c[2], c[3], c[4], c[5],c[6]);

                                    break;

                            default:
                            
                                    throw new NotAQueryException();

                            }

                        }
                        else
                        {
                            throw new EmptyValuesException();
                        }

                }

                
                catch (Exception e)
                {
                    ExecutedCode = "Error: " + e;
                    Msg = "Process Falied";
                }
                finally { conn.Close(); }



            }

            public void AddCustomer(String customerNAME, String customerADDRESS, String cellNUMBER, String EmailADDRESS)
            {

                

                String code =
                        "INSERT INTO CUSTOMERS (" +
                        "customerNAME," +
                        "customerADDRESS," +
                        "cellNUMBER," +
                        "EmailADDRESS" +
                        ")VALUES(" +
                        "'" + customerNAME + "'," +
                        "'" + customerADDRESS + "'," +
                        "'" + cellNUMBER + "'," +
                        "'" + EmailADDRESS + "'" +
                        ");";

                Execute(code);
                
            }

            public void AddConstgnor(String ConstgnorNAME, String ConstgnorADDRESS, String cellNUMBER, String EmailADDRESS)
            {


                String code =
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

            public void AddPayMethod(String payTYPE)
            {

                String code =
                        "INSERT INTO PayMETHOD (" +
                        "payTYPE" +
                        ")VALUES(" +
                        "'" + payTYPE + "'" +
                        ");";

                Execute(code);
            }

            public void AddPosition(String positionNAME)
            {
                

                String code =
                        "INSERT INTO POSTION (" +
                        "positionNAME," +
                        ")VALUES(" +
                        "'" + positionNAME + "'" +
                        ");";

                Execute(code);
            }

            public void AddProduct(String CONSIGNOR_ID, String SKU, String productNAME, String UNIT, String PRICE, String OnHAND_QTY, String THRESHOLD, String STATUS_ID)
            {

               

                String code =
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


            public void AddEmployee(String employeeNAME, String employeeGENDER, String employeeADDRESS, String cellNUMBER, String EmailADDRESS, String employeePASSWORD, String DATE_HIRED, String SALARYperMonth, String POSITION_ID)
            {
                String code;

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

        public void AddSales(String INVENTORY_ID, String QUANTITY, String SALES_DATE, String CUSTOMER_ID, String EMPLOYEE_ID, String PAYMENT_ID, String paidAMOUNT)
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
                    ExecutedCode = ("Completed: \n------\n" + cmd.CommandText + "\n------\n" + "\n------\n");
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

            String code =
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
                    ");"+

                    "INSERT INTO FINANCES (" +
                    "payTYPE" +
                    ")VALUES(" +
                    "'" + INVENTORY_ID + "'," +
                    ");" +

                    "UPDATE INVENTORY"+
                    "SET OnHAND_QTY = OnHAND_QTY - " + QUANTITY +
                    "WHERE INVENTORY_ID = " + INVENTORY_ID;
            
            Execute(code);

        }


        class NotAQueryException : Exception 
        {
            public NotAQueryException()
            {

                Console.Write("NotAQueryException: Not a valid SQL Query in this database.");

            }
        }

        class EmptyValuesException : Exception
        {
            public EmptyValuesException()
            {

                Console.Write("EmptyValuesException: SQL Query Values can not be empty.");

            }
        }

    }
}
