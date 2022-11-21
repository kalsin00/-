
namespace WindowsFormsApp8
{
    partial class PoiskForm
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
            this.преподавателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pZKUPDataSet5 = new WindowsFormsApp8.PZKUPDataSet5();
            this.button1 = new System.Windows.Forms.Button();
            this.преподавателиTableAdapter = new WindowsFormsApp8.PZKUPDataSet5TableAdapters.ПреподавателиTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pZKUPDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1120, 571);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // преподавателиBindingSource
            // 
            this.преподавателиBindingSource.DataMember = "Преподаватели";
            this.преподавателиBindingSource.DataSource = this.pZKUPDataSet5;
            // 
            // pZKUPDataSet5
            // 
            this.pZKUPDataSet5.DataSetName = "PZKUPDataSet5";
            this.pZKUPDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Play", 9.749999F);
            this.button1.Location = new System.Drawing.Point(1021, 663);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // преподавателиTableAdapter
            // 
            this.преподавателиTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Play", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(30, 663);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Загрузить запрос";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Play", 9.749999F);
            this.radioButton3.Location = new System.Drawing.Point(373, 723);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 21);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ФИО";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Play", 9.749999F);
            this.radioButton2.Location = new System.Drawing.Point(373, 663);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 21);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Адрес";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Play", 9.749999F);
            this.radioButton1.Location = new System.Drawing.Point(373, 693);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 21);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Название";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Play", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(477, 694);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Play", 9.749999F);
            this.radioButton4.Location = new System.Drawing.Point(477, 663);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(110, 21);
            this.radioButton4.TabIndex = 20;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Председатель";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(473, 628);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "ФИЛЬТРАЦИЯ";
            // 
            // PoiskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1213, 757);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Play", 9.749999F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PoiskForm";
            this.Text = "Кальсин И.И.";
            this.Load += new System.EventHandler(this.PoiskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pZKUPDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        public PZKUPDataSet5 pZKUPDataSet5;
        public System.Windows.Forms.BindingSource преподавателиBindingSource;
        public PZKUPDataSet5TableAdapters.ПреподавателиTableAdapter преподавателиTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label1;
    }
}