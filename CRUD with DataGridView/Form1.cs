using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using System.Data.SqlClient;

namespace CRUD_with_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRUD_with_DataGridViewDatabaseDataSet.Table' table. You can move, or remove it, as needed.
            //this.tableTableAdapter.Fill(this.cRUD_with_DataGridViewDatabaseDataSet.Table);

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // Check if any of the text boxes are empty
            if (string.IsNullOrWhiteSpace(textBox_id.Text) ||
                string.IsNullOrWhiteSpace(textBox_name.Text) ||
                string.IsNullOrWhiteSpace(textBox_phonenumber.Text) ||
                string.IsNullOrWhiteSpace(textBox_address.Text))
            {
                MessageBox.Show("All fields must be filled.");
                return; // Exit the method if validation fails
            }

            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\project202\\CRUD with DataGridView\\Database\\CRUD with DataGridViewDatabase.mdf\";Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    // Check if the ID is already registered
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM [Table] WHERE id = @id", con);
                    checkCmd.Parameters.AddWithValue("@id", textBox_id.Text);
                    int idExists = (int)checkCmd.ExecuteScalar();

                    if (idExists > 0)
                    {
                        MessageBox.Show("This ID is already registered.");
                        return; // Exit the method if ID already exists
                    }

                    // If ID is not already registered, insert the new record
                    SqlCommand cmd = new SqlCommand("INSERT INTO [Table] (id, name, phonenumber, address) VALUES (@id, @name, @phonenumber, @address)", con);
                    cmd.Parameters.AddWithValue("@id", textBox_id.Text);
                    cmd.Parameters.AddWithValue("@name", textBox_name.Text);
                    cmd.Parameters.AddWithValue("@phonenumber", textBox_phonenumber.Text);
                    cmd.Parameters.AddWithValue("@address", textBox_address.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Saved");

                    // Now retrieve all data from the table to show in the DataGridView
                    SqlCommand selectCmd = new SqlCommand("SELECT * FROM [Table]", con);
                    SqlDataAdapter da = new SqlDataAdapter(selectCmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }



        private void button_update_Click(object sender, EventArgs e)
        {
            // Check if the user has entered an ID
            if (string.IsNullOrWhiteSpace(textBox_id.Text))
            {
                MessageBox.Show("ID is mandatory for updating. Please fill in the ID.");
                return; // Exit the method to prevent further execution
            }

            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\project202\\CRUD with DataGridView\\Database\\CRUD with DataGridViewDatabase.mdf\";Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    // Check if the ID exists before updating
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM [Table] WHERE id = @id", con);
                    checkCmd.Parameters.AddWithValue("@id", textBox_id.Text);
                    int idExists = (int)checkCmd.ExecuteScalar();

                    if (idExists == 0)
                    {
                        MessageBox.Show("ID does not exist. Please provide a valid ID.");
                        return; // Exit the method if the ID does not exist
                    }

                    // Update the record without changing the ID
                    SqlCommand cmd = new SqlCommand("UPDATE [Table] SET name = @name, phonenumber = @phonenumber, address = @address WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", textBox_id.Text); // ID remains unchanged
                    cmd.Parameters.AddWithValue("@name", textBox_name.Text);
                    cmd.Parameters.AddWithValue("@phonenumber", textBox_phonenumber.Text);
                    cmd.Parameters.AddWithValue("@address", textBox_address.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Updated");

                    // Refresh the DataGridView with updated data
                    SqlCommand selectCmd = new SqlCommand("SELECT * FROM [Table]", con);
                    SqlDataAdapter da = new SqlDataAdapter(selectCmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void button_delete_Click(object sender, EventArgs e)
        {
            // Check if the user has entered an ID
            if (string.IsNullOrWhiteSpace(textBox_id.Text))
            {
                MessageBox.Show("ID is mandatory for deleting. Please fill in the ID.");
                return; // Exit the method to prevent further execution
            }

            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\project202\\CRUD with DataGridView\\Database\\CRUD with DataGridViewDatabase.mdf\";Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    // Check if the ID exists before attempting to delete
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM [Table] WHERE id = @id", con);
                    checkCmd.Parameters.AddWithValue("@id", textBox_id.Text);
                    int idExists = (int)checkCmd.ExecuteScalar();

                    if (idExists == 0)
                    {
                        MessageBox.Show("No data found for the given ID.");
                        return; // Exit the method if no matching ID is found
                    }

                    // If the ID exists, proceed with the deletion
                    SqlCommand cmd = new SqlCommand("DELETE FROM [Table] WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", textBox_id.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Deleted");

                    // Now retrieve the updated data from the table to show in the DataGridView
                    SqlCommand selectCmd = new SqlCommand("SELECT * FROM [Table]", con);
                    SqlDataAdapter da = new SqlDataAdapter(selectCmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind the DataTable to the DataGridView to reflect the updated data
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the user entered a value in the search TextBox
            if (string.IsNullOrWhiteSpace(textBox_search_id.Text))
            {
                MessageBox.Show("Please enter a valid ID.");
                return; // Exit the method to prevent further execution
            }

            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\project202\\CRUD with DataGridView\\Database\\CRUD with DataGridViewDatabase.mdf\";Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    // Prepare the SQL query to search for the specified ID
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [Table] WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", textBox_search_id.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Check if any rows were returned
                    if (dt.Rows.Count > 0)
                    {
                        // Bind the DataTable to the DataGridView to show the results
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        // Show a message if no matching ID is found
                        MessageBox.Show("No registered ID is available.");
                        dataGridView1.DataSource = null; // Clear the DataGridView if nothing is found
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button_show_alldata_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\project202\\CRUD with DataGridView\\Database\\CRUD with DataGridViewDatabase.mdf\";Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    // Query to select all data from the table
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [Table]", con);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Check if any rows were returned
                    if (dt.Rows.Count > 0)
                    {
                        // Bind the DataTable to the DataGridView to show the results
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        // If no data is found, clear the DataGridView
                        dataGridView1.DataSource = null;
                        MessageBox.Show("No data found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void textBox_id_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_phonenumber_Enter(object sender, EventArgs e)
        {

        }
    }
}
