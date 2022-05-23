﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Resurtant_project
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public int check_pass(string name, string pass)
        {
            String StoredProcedureName = StoredProcedures.checkpass;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", name);
            Parameters.Add("@Pass", pass);
/*            if (dbMan.ExecuteReader(StoredProcedureName, Parameters) != null)
            {*/
                //MessageBox.Show(dbMan.ExecuteReader(query).Rows[0][2].ToString());
                return Int16.Parse(dbMan.ExecuteScalar(StoredProcedureName, Parameters).ToString());
/*           }
            else
            {
                return 0;
            }*/
        }

        public void removeForm(string name)
        {
            String StoredProcedureName = StoredProcedures.removeBranch;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@BranchName", name);
            dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public void addBranch(string bname, int id, string location, int btax, int bsup_ssn)
        {
            String StoredProcedureName = StoredProcedures.addbranch;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@BranchName", bname);
            Parameters.Add("@ID", id);
            Parameters.Add("@Blocation", location);
            Parameters.Add("@BranchTax", btax);
            Parameters.Add("@BranchSupSSN", bsup_ssn);
            dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable ShowInfo()
        {
            String storedProcedure = StoredProcedures.GetBranchInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(storedProcedure, Parameters);
        }
        public DataTable GetBranchNames()
        {
            String StoredProcedureName = StoredProcedures.getAllBranches;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            //Parameters.Add("@location", location);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public void InsertCInfo(int PNum , string name , string address)
        {
            String StoredProcedureName = StoredProcedures.InsertCoustmerInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNumber", PNum);
            Parameters.Add("@CName", name);
            Parameters.Add("@CAdd", address);
            dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetMenu(string MName)
        {
            String StoredProcedureName = StoredProcedures.GetMenu;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@MenuName", MName);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int GetLastOrderID()
        {
            String StoredProcedureName = StoredProcedures.GetMenu;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            //Parameters.Add("@MenuName", MName);
           return Int32.Parse(dbMan.ExecuteScalar(StoredProcedureName, Parameters).ToString());
        }


        public void InsertTupleOrderR(int orderii , int pphone , string fname)
        {
            String StoredProcedureName = StoredProcedures.GetMenu;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@orderii", orderii);
            Parameters.Add("@pphone", pphone);
            Parameters.Add("@FoodNAme", fname);
            dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public void InsertEmployee(string ename, string ejob, string edate, int esalary, int eid)
        {
            String StoredProcedureName = StoredProcedures.InsertEmployee;
            Dictionary<string , object> Parameters = new Dictionary<string , object>();
            Parameters.Add("@ename", ename);
            Parameters.Add("@ejob", ejob);
            Parameters.Add("@edate", edate);
            Parameters.Add("@esalary", esalary);
            Parameters.Add("@eid", eid);
            dbMan.ExecuteNonQuery (StoredProcedureName, Parameters);
        }



        ////////////
        public void InsertFoodItem(int ID, string name, float Price, string MenuName )
        {
            String StoredProcedureName = StoredProcedures.InsertFoodItem;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Item_ID", ID);
            Parameters.Add("@Item_Name", name);
            Parameters.Add("@Item_Price", Price);
            Parameters.Add("@Menu_Name", MenuName);
          
            dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public void DeleteFoodItemByName( string name , string MenuName)
        {
            String StoredProcedureName = StoredProcedures.DeleteFoodItemByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Item_Name", name);
            Parameters.Add("@Menu_Name", MenuName);
            dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public void EditFoodItemByName(string MenuName , string name , string newname ,float newprice )
        {
            String StoredProcedureName = StoredProcedures.EditFoodItemByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Menu_Name", MenuName);
            Parameters.Add("@CurrentItem_Nama", name);
            Parameters.Add("@NewItem_Name", newname);
            Parameters.Add("@NewItem_Price", newprice);
            dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public void SelectAllMenusNames()
        {
            String StoredProcedureName = StoredProcedures.SelectAllMenusNames;
           
            
            dbMan.ExecuteReader(StoredProcedureName, null);
        }

        






        public DataTable GetProfits(string fromDate, string toDate)
        {
            String StoredProcedureName = StoredProcedures.GetProfits;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@fromDate", fromDate);
            Parameters.Add("@toDate", toDate);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public DataTable GetHistory(string fromDate, string toDate)
        {
            String StoredProcedureName = StoredProcedures.GetHistory;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@fromDate", fromDate);
            Parameters.Add("@toDate", toDate);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public string GetSupervisedBranch(string sname)
        {
            String StoredProcedureName = StoredProcedures.GetSupervisedBranch;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Sname", sname);
            return (string) dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }

    }
}
