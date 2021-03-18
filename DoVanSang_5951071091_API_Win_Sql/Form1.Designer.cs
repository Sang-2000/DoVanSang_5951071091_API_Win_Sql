
namespace DoVanSang_5951071091_API_Win_Sql
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRollNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bbtnXoa = new System.Windows.Forms.Button();
            this.btnXacLap = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btbThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.StudentRecortData = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoCRUDDataSet = new DoVanSang_5951071091_API_Win_Sql.demoCRUDDataSet();
            this.studentTbTableAdapter = new DoVanSang_5951071091_API_Win_Sql.demoCRUDDataSetTableAdapters.StudentTbTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecortData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoCRUDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFatherName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(430, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 34);
            this.panel1.TabIndex = 0;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(108, 4);
            this.txtFatherName.Multiline = true;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(136, 27);
            this.txtFatherName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ sinh viên:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtRollNumber);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(96, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 34);
            this.panel2.TabIndex = 1;
            // 
            // txtRollNumber
            // 
            this.txtRollNumber.Location = new System.Drawing.Point(108, 4);
            this.txtRollNumber.Multiline = true;
            this.txtRollNumber.Name = "txtRollNumber";
            this.txtRollNumber.Size = new System.Drawing.Size(136, 27);
            this.txtRollNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số báo danh:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(96, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 34);
            this.panel3.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(108, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(136, 27);
            this.txtAddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtMobile);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(427, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 34);
            this.panel4.TabIndex = 2;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(108, 4);
            this.txtMobile.Multiline = true;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(136, 27);
            this.txtMobile.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số điện thoại:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(99, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(247, 34);
            this.panel5.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 27);
            this.txtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên sinh viên:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.bbtnXoa);
            this.panel6.Controls.Add(this.btnXacLap);
            this.panel6.Controls.Add(this.btnCapNhat);
            this.panel6.Controls.Add(this.btbThem);
            this.panel6.Location = new System.Drawing.Point(96, 161);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(422, 39);
            this.panel6.TabIndex = 3;
            // 
            // bbtnXoa
            // 
            this.bbtnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bbtnXoa.Location = new System.Drawing.Point(318, 3);
            this.bbtnXoa.Name = "bbtnXoa";
            this.bbtnXoa.Size = new System.Drawing.Size(99, 33);
            this.bbtnXoa.TabIndex = 9;
            this.bbtnXoa.Text = "Xóa";
            this.bbtnXoa.UseVisualStyleBackColor = true;
            this.bbtnXoa.Click += new System.EventHandler(this.bbtnXoa_Click);
            // 
            // btnXacLap
            // 
            this.btnXacLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacLap.Location = new System.Drawing.Point(213, 3);
            this.btnXacLap.Name = "btnXacLap";
            this.btnXacLap.Size = new System.Drawing.Size(99, 33);
            this.btnXacLap.TabIndex = 8;
            this.btnXacLap.Text = "Xác lập";
            this.btnXacLap.UseVisualStyleBackColor = true;
            this.btnXacLap.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.Location = new System.Drawing.Point(108, 3);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(99, 33);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btbThem
            // 
            this.btbThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btbThem.Location = new System.Drawing.Point(3, 3);
            this.btbThem.Name = "btbThem";
            this.btbThem.Size = new System.Drawing.Size(99, 33);
            this.btbThem.TabIndex = 6;
            this.btbThem.Text = "Thêm";
            this.btbThem.UseVisualStyleBackColor = true;
            this.btbThem.Click += new System.EventHandler(this.btbThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(689, 164);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 33);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // StudentRecortData
            // 
            this.StudentRecortData.AutoGenerateColumns = false;
            this.StudentRecortData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentRecortData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentRecortData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fatherNameDataGridViewTextBoxColumn,
            this.rollNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn});
            this.StudentRecortData.DataSource = this.studentTbBindingSource;
            this.StudentRecortData.Location = new System.Drawing.Point(12, 206);
            this.StudentRecortData.Name = "StudentRecortData";
            this.StudentRecortData.Size = new System.Drawing.Size(776, 269);
            this.StudentRecortData.TabIndex = 8;
            this.StudentRecortData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentRecortData_CellClick);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // fatherNameDataGridViewTextBoxColumn
            // 
            this.fatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.HeaderText = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
            // 
            // rollNumberDataGridViewTextBoxColumn
            // 
            this.rollNumberDataGridViewTextBoxColumn.DataPropertyName = "RollNumber";
            this.rollNumberDataGridViewTextBoxColumn.HeaderText = "RollNumber";
            this.rollNumberDataGridViewTextBoxColumn.Name = "rollNumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // studentTbBindingSource
            // 
            this.studentTbBindingSource.DataMember = "StudentTb";
            this.studentTbBindingSource.DataSource = this.demoCRUDDataSet;
            // 
            // demoCRUDDataSet
            // 
            this.demoCRUDDataSet.DataSetName = "demoCRUDDataSet";
            this.demoCRUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTbTableAdapter
            // 
            this.studentTbTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.StudentRecortData);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Student Infomation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecortData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoCRUDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRollNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button bbtnXoa;
        private System.Windows.Forms.Button btnXacLap;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btbThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView StudentRecortData;
        private demoCRUDDataSet demoCRUDDataSet;
        private System.Windows.Forms.BindingSource studentTbBindingSource;
        private demoCRUDDataSetTableAdapters.StudentTbTableAdapter studentTbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
    }
}

