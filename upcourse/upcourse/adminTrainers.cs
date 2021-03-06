﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace upcourse
{
    public partial class adminTrainers : UserControl
    {
        public adminTrainers()
        {
            InitializeComponent();
            SqlCommand Courses = new SqlCommand("select * from Trainer", Program.dbconnection);
            SqlDataReader data = Courses.ExecuteReader();

            while (data.Read())
            {
                TrainersPanel pnl = new TrainersPanel(data.GetString(data.GetOrdinal("UserName")), data.GetString(data.GetOrdinal("FirstName")),
                data.GetString(data.GetOrdinal("LastName")), data.GetInt32(data.GetOrdinal("iD")), data.GetString(data.GetOrdinal("Email")),
                data.GetString(data.GetOrdinal("Gender")));
                FlowLayoutPanel.Controls.Add(pnl);


            }
            data.Close();
        }
       

    }
}
