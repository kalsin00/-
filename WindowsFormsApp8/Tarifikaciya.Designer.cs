
namespace WindowsFormsApp8
{
    partial class Tarifikaciya
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pZKUPDataSet7 = new WindowsFormsApp8.PZKUPDataSet7();
            this.тарификацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тарификацияTableAdapter = new WindowsFormsApp8.PZKUPDataSet7TableAdapters.ТарификацияTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.pZKUPDataSet8 = new WindowsFormsApp8.PZKUPDataSet8();
            this.учебныйпланBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учебный_планTableAdapter = new WindowsFormsApp8.PZKUPDataSet8TableAdapters.Учебный_планTableAdapter();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pZKUPDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарификацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pZKUPDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебныйпланBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1120, 571);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Play", 9.749999F);
            this.button1.Location = new System.Drawing.Point(982, 663);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pZKUPDataSet7
            // 
            this.pZKUPDataSet7.DataSetName = "PZKUPDataSet7";
            this.pZKUPDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тарификацияBindingSource
            // 
            this.тарификацияBindingSource.DataMember = "Тарификация";
            this.тарификацияBindingSource.DataSource = this.pZKUPDataSet7;
            // 
            // тарификацияTableAdapter
            // 
            this.тарификацияTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Play", 9.749999F);
            this.button2.Location = new System.Drawing.Point(88, 663);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Загрузить запрос";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pZKUPDataSet8
            // 
            this.pZKUPDataSet8.DataSetName = "PZKUPDataSet8";
            this.pZKUPDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // учебныйпланBindingSource
            // 
            this.учебныйпланBindingSource.DataMember = "Учебный_план";
            this.учебныйпланBindingSource.DataSource = this.pZKUPDataSet8;
            // 
            // учебный_планTableAdapter
            // 
            this.учебный_планTableAdapter.ClearBeforeFill = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Play", 9.749999F);
            this.radioButton3.Location = new System.Drawing.Point(366, 701);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 21);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ФИО";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Play", 9.749999F);
            this.radioButton2.Location = new System.Drawing.Point(366, 641);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 21);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Группа";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Play", 9.749999F);
            this.radioButton1.Location = new System.Drawing.Point(366, 671);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 21);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Полное";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Play", 9.749999F);
            this.textBox1.Location = new System.Drawing.Point(502, 671);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(446, 609);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "ФИЛЬТРАЦИЯ";
            // 
            // Tarifikaciya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1213, 757);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Play", 9.749999F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tarifikaciya";
            this.Text = "Кальсин И.И.";
            this.Load += new System.EventHandler(this.Tarifikaciya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pZKUPDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарификацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pZKUPDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебныйпланBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        public PZKUPDataSet7 pZKUPDataSet7;
        public System.Windows.Forms.BindingSource тарификацияBindingSource;
        public PZKUPDataSet7TableAdapters.ТарификацияTableAdapter тарификацияTableAdapter;
        private System.Windows.Forms.Button button2;
        private PZKUPDataSet8 pZKUPDataSet8;
        private System.Windows.Forms.BindingSource учебныйпланBindingSource;
        private PZKUPDataSet8TableAdapters.Учебный_планTableAdapter учебный_планTableAdapter;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}