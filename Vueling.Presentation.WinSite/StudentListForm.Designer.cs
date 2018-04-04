namespace Vueling.Presentation.WinSite
{
    partial class StudentListForm
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
            this.dGVStudents = new System.Windows.Forms.DataGridView();
            this.buttonReadTxt = new System.Windows.Forms.Button();
            this.buttonReadJson = new System.Windows.Forms.Button();
            this.buttonReadXml = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.textBoxGuid = new System.Windows.Forms.TextBox();
            this.buttonId = new System.Windows.Forms.Button();
            this.buttonNombre = new System.Windows.Forms.Button();
            this.buttonApellidos = new System.Windows.Forms.Button();
            this.buttonEdad = new System.Windows.Forms.Button();
            this.buttonDni = new System.Windows.Forms.Button();
            this.buttonGuid = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelGuid = new System.Windows.Forms.Label();
            this.labelBuscartext = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonBusquedaGeneral = new System.Windows.Forms.Button();
            this.textBoxBusquedaGeneral = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVStudents
            // 
            this.dGVStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStudents.Location = new System.Drawing.Point(12, 175);
            this.dGVStudents.Name = "dGVStudents";
            this.dGVStudents.Size = new System.Drawing.Size(605, 200);
            this.dGVStudents.TabIndex = 0;
            // 
            // buttonReadTxt
            // 
            this.buttonReadTxt.Location = new System.Drawing.Point(13, 13);
            this.buttonReadTxt.Name = "buttonReadTxt";
            this.buttonReadTxt.Size = new System.Drawing.Size(73, 45);
            this.buttonReadTxt.TabIndex = 1;
            this.buttonReadTxt.Text = "Read From Txt File";
            this.buttonReadTxt.UseVisualStyleBackColor = true;
            // 
            // buttonReadJson
            // 
            this.buttonReadJson.Location = new System.Drawing.Point(92, 13);
            this.buttonReadJson.Name = "buttonReadJson";
            this.buttonReadJson.Size = new System.Drawing.Size(73, 45);
            this.buttonReadJson.TabIndex = 2;
            this.buttonReadJson.Text = "Read From Json File";
            this.buttonReadJson.UseVisualStyleBackColor = true;
            // 
            // buttonReadXml
            // 
            this.buttonReadXml.Location = new System.Drawing.Point(171, 13);
            this.buttonReadXml.Name = "buttonReadXml";
            this.buttonReadXml.Size = new System.Drawing.Size(73, 45);
            this.buttonReadXml.TabIndex = 3;
            this.buttonReadXml.Text = "Read From Json File";
            this.buttonReadXml.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(12, 109);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(118, 109);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 5;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(224, 109);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellidos.TabIndex = 6;
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(330, 109);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdad.TabIndex = 7;
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(436, 109);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(100, 20);
            this.textBoxDni.TabIndex = 8;
            // 
            // textBoxGuid
            // 
            this.textBoxGuid.Location = new System.Drawing.Point(542, 109);
            this.textBoxGuid.Name = "textBoxGuid";
            this.textBoxGuid.Size = new System.Drawing.Size(100, 20);
            this.textBoxGuid.TabIndex = 9;
            // 
            // buttonId
            // 
            this.buttonId.Location = new System.Drawing.Point(13, 135);
            this.buttonId.Name = "buttonId";
            this.buttonId.Size = new System.Drawing.Size(75, 34);
            this.buttonId.TabIndex = 10;
            this.buttonId.Text = "Buscar por Id";
            this.buttonId.UseVisualStyleBackColor = true;
            // 
            // buttonNombre
            // 
            this.buttonNombre.Location = new System.Drawing.Point(118, 135);
            this.buttonNombre.Name = "buttonNombre";
            this.buttonNombre.Size = new System.Drawing.Size(75, 34);
            this.buttonNombre.TabIndex = 11;
            this.buttonNombre.Text = "Buscar por Nombre";
            this.buttonNombre.UseVisualStyleBackColor = true;
            // 
            // buttonApellidos
            // 
            this.buttonApellidos.Location = new System.Drawing.Point(224, 135);
            this.buttonApellidos.Name = "buttonApellidos";
            this.buttonApellidos.Size = new System.Drawing.Size(75, 34);
            this.buttonApellidos.TabIndex = 12;
            this.buttonApellidos.Text = "Buscar por Apellidos";
            this.buttonApellidos.UseVisualStyleBackColor = true;
            // 
            // buttonEdad
            // 
            this.buttonEdad.Location = new System.Drawing.Point(330, 135);
            this.buttonEdad.Name = "buttonEdad";
            this.buttonEdad.Size = new System.Drawing.Size(75, 34);
            this.buttonEdad.TabIndex = 13;
            this.buttonEdad.Text = "Buscar por Edad";
            this.buttonEdad.UseVisualStyleBackColor = true;
            // 
            // buttonDni
            // 
            this.buttonDni.Location = new System.Drawing.Point(436, 135);
            this.buttonDni.Name = "buttonDni";
            this.buttonDni.Size = new System.Drawing.Size(75, 34);
            this.buttonDni.TabIndex = 14;
            this.buttonDni.Text = "Buscar por Dni";
            this.buttonDni.UseVisualStyleBackColor = true;
            // 
            // buttonGuid
            // 
            this.buttonGuid.Location = new System.Drawing.Point(542, 135);
            this.buttonGuid.Name = "buttonGuid";
            this.buttonGuid.Size = new System.Drawing.Size(75, 34);
            this.buttonGuid.TabIndex = 15;
            this.buttonGuid.Text = "Buscar por Guid";
            this.buttonGuid.UseVisualStyleBackColor = true;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(623, 346);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(83, 29);
            this.buttonVolver.TabIndex = 16;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(115, 90);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 17;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(221, 90);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(52, 13);
            this.labelApellidos.TabIndex = 18;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 90);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 19;
            this.labelId.Text = "Id:";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(327, 90);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(35, 13);
            this.labelEdad.TabIndex = 20;
            this.labelEdad.Text = "Edad:";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(433, 90);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(26, 13);
            this.labelDni.TabIndex = 21;
            this.labelDni.Text = "Dni:";
            // 
            // labelGuid
            // 
            this.labelGuid.AutoSize = true;
            this.labelGuid.Location = new System.Drawing.Point(539, 90);
            this.labelGuid.Name = "labelGuid";
            this.labelGuid.Size = new System.Drawing.Size(32, 13);
            this.labelGuid.TabIndex = 22;
            this.labelGuid.Text = "Guid:";
            // 
            // labelBuscartext
            // 
            this.labelBuscartext.AutoSize = true;
            this.labelBuscartext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscartext.Location = new System.Drawing.Point(12, 70);
            this.labelBuscartext.Name = "labelBuscartext";
            this.labelBuscartext.Size = new System.Drawing.Size(72, 13);
            this.labelBuscartext.TabIndex = 23;
            this.labelBuscartext.Text = "Buscar por:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Apellidos",
            "Edad",
            "Dni",
            "Guid"});
            this.checkedListBox1.Location = new System.Drawing.Point(250, 13);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(298, 49);
            this.checkedListBox1.TabIndex = 24;
            // 
            // buttonBusquedaGeneral
            // 
            this.buttonBusquedaGeneral.Location = new System.Drawing.Point(554, 39);
            this.buttonBusquedaGeneral.Name = "buttonBusquedaGeneral";
            this.buttonBusquedaGeneral.Size = new System.Drawing.Size(100, 23);
            this.buttonBusquedaGeneral.TabIndex = 25;
            this.buttonBusquedaGeneral.Text = "Buscar";
            this.buttonBusquedaGeneral.UseVisualStyleBackColor = true;
            // 
            // textBoxBusquedaGeneral
            // 
            this.textBoxBusquedaGeneral.Location = new System.Drawing.Point(554, 13);
            this.textBoxBusquedaGeneral.Name = "textBoxBusquedaGeneral";
            this.textBoxBusquedaGeneral.Size = new System.Drawing.Size(100, 20);
            this.textBoxBusquedaGeneral.TabIndex = 26;
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 387);
            this.Controls.Add(this.textBoxBusquedaGeneral);
            this.Controls.Add(this.buttonBusquedaGeneral);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.labelBuscartext);
            this.Controls.Add(this.labelGuid);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonGuid);
            this.Controls.Add(this.buttonDni);
            this.Controls.Add(this.buttonEdad);
            this.Controls.Add(this.buttonApellidos);
            this.Controls.Add(this.buttonNombre);
            this.Controls.Add(this.buttonId);
            this.Controls.Add(this.textBoxGuid);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonReadXml);
            this.Controls.Add(this.buttonReadJson);
            this.Controls.Add(this.buttonReadTxt);
            this.Controls.Add(this.dGVStudents);
            this.Name = "StudentListForm";
            this.Text = "StudentList";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVStudents;
        private System.Windows.Forms.Button buttonReadTxt;
        private System.Windows.Forms.Button buttonReadJson;
        private System.Windows.Forms.Button buttonReadXml;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.TextBox textBoxGuid;
        private System.Windows.Forms.Button buttonId;
        private System.Windows.Forms.Button buttonNombre;
        private System.Windows.Forms.Button buttonApellidos;
        private System.Windows.Forms.Button buttonEdad;
        private System.Windows.Forms.Button buttonDni;
        private System.Windows.Forms.Button buttonGuid;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelGuid;
        private System.Windows.Forms.Label labelBuscartext;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonBusquedaGeneral;
        private System.Windows.Forms.TextBox textBoxBusquedaGeneral;
    }
}