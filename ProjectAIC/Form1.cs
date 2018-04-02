using Net.Code.ADONet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAIC
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private EntityState objState;
        private string currentFileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(ofd.FileName);
                    Employee obj = employeeBindingSource.Current as Employee;
                    if (obj != null)
                    {
                        currentFileName = ofd.FileName;
                        obj.ImageUrl = currentFileName;
                    }
                }
            }
        }

        private void clearInput()
        {
            pibText.Text = null;
            ageText.Text = null;
            positionText.Text = null;
            pic.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = Db.FromConfig("cn"))
            {
                int number = db.Sql("select count(*) from Employees").AsScalar<int>();
                //MetroFramework.MetroMessageBox.Show(this, number.ToString(), "Message");
                if (number != 0)
                {
                    employeeBindingSource.DataSource = db.Sql("select * from Employees").AsEnumerable<Employee>();
                    Employee obj = employeeBindingSource.Current as Employee;
                    if (obj != null)
                    {
                        string url = obj.ImageUrl;
                        if (url != null)
                        {
                            pic.Image = Image.FromFile(url);
                        }
                    }
                    infoPanel.Enabled = false;
                }
            }
            infoPanel.Enabled = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            Employee obj = new Employee();
            obj.PIB = pibText.Text;
            int num = 0;
            int.TryParse(ageText.Text, out num);
            obj.Age = num;
            obj.Position = positionText.Text;
            int.TryParse(ageText.Text, out num);
            obj.Salary = num;
            obj.ImageUrl = currentFileName;
            MetroFramework.MetroMessageBox.Show(this, currentFileName, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            employeeBindingSource.Add(obj);
            employeeBindingSource.MoveLast();
            pibText.Focus();
        }

        private void employeeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                employeeBindingSource.EndEdit();
                Employee obj = employeeBindingSource.Current as Employee;
                using (var db = Db.FromConfig("cn"))
                {
                    if (objState == EntityState.Added)
                    {
                        obj.EmployeeId = db.Sql("insert into Employees(PIB, Age, Position, Salary, ImageUrl) values(@PIB, @Age, @Position, @Salary, @ImageUrl);select SCOPE_IDENTITY()").WithParameters(new { PIB = obj.PIB, Age = obj.Age, Position = obj.Position, Salary = obj.Salary, ImageUrl = obj.ImageUrl }).AsScalar<int>();
                        MetroFramework.MetroMessageBox.Show(this, "Employee was successfully added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (objState == EntityState.Changed)
                    {
                       db.Sql("update Employees set PIB=@PIB, Age=@Age, Position=@Position, Salary=@Salary, Position=@Position where EmployeeId = @EmployeeId").WithParameters(new { EmployeeId = obj.EmployeeId, PIB = obj.PIB, Age = obj.Age, Position = obj.Position, Salary = obj.Salary, ImageUrl = obj.ImageUrl }).AsScalar<int>();
                    }
                    
                }
                metroGrid1.Refresh();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pic.Image = null;
            Employee obj = employeeBindingSource.Current as Employee;
            if (obj != null)
            {
                if (!string.IsNullOrEmpty(obj.ImageUrl))
                {
                    pic.Image = Image.FromFile(obj.ImageUrl);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you shure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Employee obj = employeeBindingSource.Current as Employee;
                    if (obj != null)
                    {
                        using(var db = Db.FromConfig("cn"))
                        {
                            db.Sql("delete from Employees where EmployeeId = @EmployeeId").WithParameters(new { EmployeeId = obj.EmployeeId }).AsNonQuery();
                            employeeBindingSource.RemoveCurrent();
                            metroGrid1.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                metroGrid1.Enabled = true;
            }
        }
    }
}
