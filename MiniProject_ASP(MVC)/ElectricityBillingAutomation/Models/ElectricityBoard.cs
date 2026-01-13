using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using ElectricityBillingAutomation.Models;

namespace ElectricityBillingAutomation.BusinessLogic
{
    public class ElectricityBoard
    {
        // ✅ Calculate bill amount based on correct slab rates
        public void CalculateBill(ElectricityBill ebill)
        {
            int units = ebill.UnitsConsumed;
            double amount = 0;

            if (units <= 100)
            {
                amount = 0; // First 100 units free
            }
            else if (units <= 300)
            {
                amount = (units - 100) * 1.5;
            }
            else if (units <= 600)
            {
                amount = (200 * 1.5) + ((units - 300) * 3.5);
            }
            else if (units <= 1000)
            {
                amount = (200 * 1.5) + (300 * 3.5) + ((units - 600) * 5.5);
            }
            else // > 1000
            {
                amount = (200 * 1.5) + (300 * 3.5) + (400 * 5.5) + ((units - 1000) * 7.5);
            }

            ebill.BillAmount = amount;
        }

        // ✅ Add bill to SQL database
        public void AddBill(ElectricityBill ebill)
        {
            using (SqlConnection con = new DBHandler().GetConnection())
            {
                string query = "INSERT INTO ElectricityBill (consumer_number, consumer_name, units_consumed, bill_amount) " +
                               "VALUES (@num, @name, @units, @amount)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@num", ebill.ConsumerNumber);
                cmd.Parameters.AddWithValue("@name", ebill.ConsumerName);
                cmd.Parameters.AddWithValue("@units", ebill.UnitsConsumed);
                cmd.Parameters.AddWithValue("@amount", ebill.BillAmount);

                cmd.ExecuteNonQuery();
            }
        }

        // ✅ Retrieve last N bills from SQL database
        public List<ElectricityBill> Generate_N_BillDetails(int n)
        {
           List<ElectricityBill> bills = new List<ElectricityBill>();

            using (SqlConnection con = new DBHandler().GetConnection())
            {
                string query = "SELECT TOP (@n) consumer_number, consumer_name, units_consumed, bill_amount " +
                               "FROM ElectricityBill ORDER BY consumer_number DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@n", n);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ElectricityBill eb = new ElectricityBill
                    {
                        ConsumerNumber = reader["consumer_number"].ToString(),
                        ConsumerName = reader["consumer_name"].ToString(),
                        UnitsConsumed = Convert.ToInt32(reader["units_consumed"]),
                        BillAmount = Convert.ToDouble(reader["bill_amount"])
                    };
                    bills.Add(eb);
                }
            }

            return bills;
        }
    }
}
