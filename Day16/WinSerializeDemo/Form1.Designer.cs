namespace WinSerializeDemo
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
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDserialize = new System.Windows.Forms.Button();
            this.btnXMLSerialization = new System.Windows.Forms.Button();
            this.btnXMLDeserialization = new System.Windows.Forms.Button();
            this.btnSOAPSerialization = new System.Windows.Forms.Button();
            this.btnSOAPDeserialization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(497, 130);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(132, 39);
            this.txtEmployeeID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(497, 185);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 39);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(497, 240);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(132, 39);
            this.txtSalary.TabIndex = 4;
            // 
            // btnSerialize
            // 
            this.btnSerialize.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialize.Location = new System.Drawing.Point(164, 330);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(220, 45);
            this.btnSerialize.TabIndex = 6;
            this.btnSerialize.Text = "Bin Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click_1);
            // 
            // btnDserialize
            // 
            this.btnDserialize.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDserialize.Location = new System.Drawing.Point(164, 413);
            this.btnDserialize.Name = "btnDserialize";
            this.btnDserialize.Size = new System.Drawing.Size(220, 45);
            this.btnDserialize.TabIndex = 7;
            this.btnDserialize.Text = "Bin Deserialize";
            this.btnDserialize.UseVisualStyleBackColor = true;
            this.btnDserialize.Click += new System.EventHandler(this.btnDserialize_Click);
            // 
            // btnXMLSerialization
            // 
            this.btnXMLSerialization.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLSerialization.Location = new System.Drawing.Point(427, 330);
            this.btnXMLSerialization.Name = "btnXMLSerialization";
            this.btnXMLSerialization.Size = new System.Drawing.Size(220, 45);
            this.btnXMLSerialization.TabIndex = 9;
            this.btnXMLSerialization.Text = "XML Serialization";
            this.btnXMLSerialization.UseVisualStyleBackColor = true;
            this.btnXMLSerialization.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnXMLDeserialization
            // 
            this.btnXMLDeserialization.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLDeserialization.Location = new System.Drawing.Point(427, 413);
            this.btnXMLDeserialization.Name = "btnXMLDeserialization";
            this.btnXMLDeserialization.Size = new System.Drawing.Size(220, 45);
            this.btnXMLDeserialization.TabIndex = 8;
            this.btnXMLDeserialization.Text = "XML Deserialization";
            this.btnXMLDeserialization.UseVisualStyleBackColor = true;
            this.btnXMLDeserialization.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSOAPSerialization
            // 
            this.btnSOAPSerialization.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSOAPSerialization.Location = new System.Drawing.Point(680, 330);
            this.btnSOAPSerialization.Name = "btnSOAPSerialization";
            this.btnSOAPSerialization.Size = new System.Drawing.Size(220, 45);
            this.btnSOAPSerialization.TabIndex = 11;
            this.btnSOAPSerialization.Text = "SOAP Serialization";
            this.btnSOAPSerialization.UseVisualStyleBackColor = true;
            this.btnSOAPSerialization.Click += new System.EventHandler(this.btnSOAPSerialization_Click);
            // 
            // btnSOAPDeserialization
            // 
            this.btnSOAPDeserialization.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSOAPDeserialization.Location = new System.Drawing.Point(680, 413);
            this.btnSOAPDeserialization.Name = "btnSOAPDeserialization";
            this.btnSOAPDeserialization.Size = new System.Drawing.Size(220, 45);
            this.btnSOAPDeserialization.TabIndex = 10;
            this.btnSOAPDeserialization.Text = "SOAP Deserialization";
            this.btnSOAPDeserialization.UseVisualStyleBackColor = true;
            this.btnSOAPDeserialization.Click += new System.EventHandler(this.btnSOAPDeserialization_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnSOAPSerialization);
            this.Controls.Add(this.btnSOAPDeserialization);
            this.Controls.Add(this.btnXMLSerialization);
            this.Controls.Add(this.btnXMLDeserialization);
            this.Controls.Add(this.btnDserialize);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmployeeID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDserialize;
        private System.Windows.Forms.Button btnXMLSerialization;
        private System.Windows.Forms.Button btnXMLDeserialization;
        private System.Windows.Forms.Button btnSOAPSerialization;
        private System.Windows.Forms.Button btnSOAPDeserialization;
    }
}

