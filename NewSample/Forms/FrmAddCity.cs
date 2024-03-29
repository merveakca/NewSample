using NewSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSample.Forms;
public partial class FrmAddCity : Form
{
    public FrmAddCity()
    {
        InitializeComponent();
    }

    private void btnAddCity_Click(object sender, EventArgs e)
    {
        string cityName = txtCityName.Text.Trim();

        //if(cityName == "")
        //{
        //    MessageBox.Show("City name is required");
        //    return;
        //}

        if (string.IsNullOrEmpty(cityName))
        {
            MessageBox.Show("City name is required");
            return;
        }

        AcademiUniversityContext db = new AcademiUniversityContext();

        //city classından instance aldık.
        City city = new City();
        city.Name = cityName;

        db.Cities.Add(city);
        db.SaveChanges();

        MessageBox.Show("City added successfully!");
        dataGridView1.DataSource = db.Cities.ToList();

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        AcademiUniversityContext db = new AcademiUniversityContext();
        dataGridView1.DataSource=db.Cities.ToList();
    }
}
