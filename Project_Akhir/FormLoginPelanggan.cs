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
using System.Threading;
namespace Project_Akhir
{
    public partial class FormLoginPelanggan : Form
    {
        static string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=oemah_laundry;SslMode=none";
        MySqlConnection conn = new MySqlConnection(connString);

        public FormLoginPelanggan()
        {
            InitializeComponent();
        }

        static string username;
        private void button1_Click(object sender, EventArgs e)
        {
            
            string query = "SELECT * FROM pelanggan";
            username = textBox1.Text;
            string password = textBox2.Text;
            Boolean check = false;

            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                // Open the database
                conn.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                // All succesfully executed, now do something

                // IMPORTANT : 
                // If your query returns result, use the following processor :

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if(username == reader.GetString(2) && password == reader.GetString(3))
                        {
                            check = true;
                            break;
                        }
                    }
                }
                if(check == true)
                {
                    this.Close();                    
                    Thread th = new Thread(openFormPelanggan);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                } else
                {
                    MessageBox.Show("Username atau password salah");
                }
                // Finally close the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void openFormPilihRole()
        {
            Application.Run(new FormPilihRole());
        }

        private void openFormPelanggan()
        {
            Application.Run(new FormPelanggan(username));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openFormPilihRole);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
