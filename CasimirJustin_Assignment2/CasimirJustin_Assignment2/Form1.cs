﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace CasimirJustin_Assignment2
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection();

        DataTable theData = new DataTable();

        int currentRow = 0;


        public Form1()
        {
            InitializeComponent();

            string connectionString = DBUtils.BuildConnectionString();

            //invoke the method to make the connection
            conn = DBUtils.Connect(connectionString);


            RetrieveData();
        }

        private bool RetrieveData()
        {
            //created the SQL statement.
            string sql = "SELECT FirstName, LastName, PhoneNumber, Email, Relation FROM MyContacts LIMIT 15";

            //create the DataAdapter
            MySqlDataAdapter adr = new MySqlDataAdapter(sql, conn);

            //set the type for the SELECT command
            adr.SelectCommand.CommandType = CommandType.Text;


            //The Fill method of the DataAdapter adds rows to the DataTable
            //UPDATE
            // used a try catch if data could not fill give the user a message instead of crashing.
            try
            {
                adr.Fill(theData);
            }

            catch
            {
                MessageBox.Show("Connection broken cannot fill data try again.");

            }

            //Data that needs to be put into the form
            textBoxFirstName.Text = theData.Rows[0]["FirstName"].ToString();
            textBoxLastName.Text = theData.Rows[0]["LastName"].ToString();
            numericUpDownPhoneNumber.Value = decimal.Parse(theData.Rows[0]["PhoneNumber"].ToString());
            textBoxEmail.Text = theData.Rows[0]["Email"].ToString();
            textBoxRelation.Text = theData.Rows[0]["Relation"].ToString();



            //close the connection 
            conn.Close();

            //stores the total rows
            int total = theData.Rows.Count;

            // putting the total rows in a label with text


            return true;


        }



        void HandleClientWindowSize()
        {
            //Modify ONLY these float values
            float HeightValueToChange = 1.4f;
            float WidthValueToChange = 6.0f;

            //DO NOT MODIFY THIS CODE
            int height = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Height / HeightValueToChange);
            int width = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Width / WidthValueToChange);
            if (height < Size.Height)
                height = Size.Height;
            if (width < Size.Width)
                width = Size.Width;
            this.Size = new Size(width, height);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            // changes all the current rows to the first row
            currentRow = 0;
            textBoxFirstName.Text = theData.Rows[currentRow]["FirstName"].ToString();
            textBoxLastName.Text = theData.Rows[currentRow]["LastName"].ToString();
            numericUpDownPhoneNumber.Value = decimal.Parse(theData.Rows[currentRow]["PhoneNumber"].ToString());
            textBoxEmail.Text = theData.Rows[currentRow]["Email"].ToString();
            textBoxRelation.Text = theData.Rows[currentRow]["Relation"].ToString();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentRow = theData.Rows.Count - 1;
            textBoxFirstName.Text = theData.Rows[currentRow]["FirstName"].ToString();
            textBoxLastName.Text = theData.Rows[currentRow]["LastName"].ToString();
            numericUpDownPhoneNumber.Value = decimal.Parse(theData.Rows[currentRow]["PhoneNumber"].ToString());
            textBoxEmail.Text = theData.Rows[currentRow]["Email"].ToString();
            textBoxRelation.Text = theData.Rows[currentRow]["Relation"].ToString();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentRow != 0)
            {
                currentRow--;
                textBoxFirstName.Text = theData.Rows[currentRow]["FirstName"].ToString();
                textBoxLastName.Text = theData.Rows[currentRow]["LastName"].ToString();
                numericUpDownPhoneNumber.Value = decimal.Parse(theData.Rows[currentRow]["PhoneNumber"].ToString());
                textBoxEmail.Text = theData.Rows[currentRow]["Email"].ToString();
                textBoxRelation.Text = theData.Rows[currentRow]["Relation"].ToString();

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentRow < theData.Select().Length - 1)
            {
                //update the data
                currentRow++;
                textBoxFirstName.Text = theData.Rows[currentRow]["FirstName"].ToString();
                textBoxLastName.Text = theData.Rows[currentRow]["LastName"].ToString();
                numericUpDownPhoneNumber.Value = decimal.Parse(theData.Rows[currentRow]["PhoneNumber"].ToString());
                textBoxEmail.Text = theData.Rows[currentRow]["Email"].ToString();
                textBoxRelation.Text = theData.Rows[currentRow]["Relation"].ToString();


            }



        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string connectionString = DBUtils.BuildConnectionString();

            //invoke the method to make the connection
            conn = DBUtils.Connect(connectionString);

            string sql = $"DELETE FROM ContactList.MyContacts WHERE ID= '{currentRow + 1}'";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;

            myReader = mySqlCommand.ExecuteReader();

            
            conn.Close();




            currentRow++;

            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            numericUpDownPhoneNumber.Value = 0;
            textBoxEmail.Clear();
            textBoxRelation.Clear();



            textBoxFirstName.Text = theData.Rows[currentRow]["FirstName"].ToString();
            textBoxLastName.Text = theData.Rows[currentRow]["LastName"].ToString();
            numericUpDownPhoneNumber.Value = decimal.Parse(theData.Rows[currentRow]["PhoneNumber"].ToString());
            textBoxEmail.Text = theData.Rows[currentRow]["Email"].ToString();
            textBoxRelation.Text = theData.Rows[currentRow]["Relation"].ToString();




        }






    }
}
