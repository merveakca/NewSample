namespace NewSample.Forms;

partial class FrmAddCity
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnAddCity = new Button();
        txtCityName = new TextBox();
        label1 = new Label();
        dataGridView1 = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // btnAddCity
        // 
        btnAddCity.Location = new Point(304, 113);
        btnAddCity.Name = "btnAddCity";
        btnAddCity.Size = new Size(120, 31);
        btnAddCity.TabIndex = 0;
        btnAddCity.Text = "Add";
        btnAddCity.UseVisualStyleBackColor = true;
        btnAddCity.Click += btnAddCity_Click;
        // 
        // txtCityName
        // 
        txtCityName.Location = new Point(150, 63);
        txtCityName.Name = "txtCityName";
        txtCityName.Size = new Size(274, 31);
        txtCityName.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(39, 63);
        label1.Name = "label1";
        label1.Size = new Size(94, 25);
        label1.TabIndex = 2;
        label1.Text = "City Name";
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(39, 169);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 62;
        dataGridView1.Size = new Size(642, 399);
        dataGridView1.TabIndex = 3;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // FrmAddCity
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(884, 621);
        Controls.Add(dataGridView1);
        Controls.Add(label1);
        Controls.Add(txtCityName);
        Controls.Add(btnAddCity);
        Name = "FrmAddCity";
        Text = "FrmAddCity";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnAddCity;
    private TextBox txtCityName;
    private Label label1;
    private DataGridView dataGridView1;
}