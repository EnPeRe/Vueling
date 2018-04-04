namespace Vueling.Presentation.WinSite
{
    partial class StudentForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTxt = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.textBoxFechaNacimiento = new System.Windows.Forms.TextBox();
            this.buttonJson = new System.Windows.Forms.Button();
            this.buttonXml = new System.Windows.Forms.Button();
            this.buttonToList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTxt
            // 
            this.buttonTxt.Location = new System.Drawing.Point(48, 214);
            this.buttonTxt.Name = "buttonTxt";
            this.buttonTxt.Size = new System.Drawing.Size(75, 23);
            this.buttonTxt.TabIndex = 0;
            this.buttonTxt.Text = "TXT";
            this.buttonTxt.UseVisualStyleBackColor = true;
            this.buttonTxt.Click += new System.EventHandler(this.buttonTxt_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(179, 31);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(179, 57);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(179, 83);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellidos.TabIndex = 3;
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(179, 109);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(100, 20);
            this.textBoxDni.TabIndex = 4;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(154, 34);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "Id:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(126, 60);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(121, 86);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(52, 13);
            this.labelApellido.TabIndex = 7;
            this.labelApellido.Text = "Apellidos:";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(144, 112);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(29, 13);
            this.labelDni.TabIndex = 8;
            this.labelDni.Text = "DNI:";
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(62, 138);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.labelFechaNacimiento.TabIndex = 9;
            this.labelFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // textBoxFechaNacimiento
            // 
            this.textBoxFechaNacimiento.Location = new System.Drawing.Point(179, 135);
            this.textBoxFechaNacimiento.Name = "textBoxFechaNacimiento";
            this.textBoxFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaNacimiento.TabIndex = 10;
            // 
            // buttonJson
            // 
            this.buttonJson.Location = new System.Drawing.Point(154, 214);
            this.buttonJson.Name = "buttonJson";
            this.buttonJson.Size = new System.Drawing.Size(75, 23);
            this.buttonJson.TabIndex = 11;
            this.buttonJson.Text = "JSON";
            this.buttonJson.UseVisualStyleBackColor = true;
            this.buttonJson.Click += new System.EventHandler(this.buttonJson_Click);
            // 
            // buttonXml
            // 
            this.buttonXml.Location = new System.Drawing.Point(260, 214);
            this.buttonXml.Name = "buttonXml";
            this.buttonXml.Size = new System.Drawing.Size(75, 23);
            this.buttonXml.TabIndex = 12;
            this.buttonXml.Text = "XML";
            this.buttonXml.UseVisualStyleBackColor = true;
            this.buttonXml.Click += new System.EventHandler(this.buttonXml_Click);
            // 
            // buttonToList
            // 
            this.buttonToList.Location = new System.Drawing.Point(13, 13);
            this.buttonToList.Name = "buttonToList";
            this.buttonToList.Size = new System.Drawing.Size(76, 38);
            this.buttonToList.TabIndex = 13;
            this.buttonToList.Text = "mostra tots els alumnes";
            this.buttonToList.UseVisualStyleBackColor = true;
            this.buttonToList.Click += new System.EventHandler(this.buttonToList_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 295);
            this.Controls.Add(this.buttonToList);
            this.Controls.Add(this.buttonXml);
            this.Controls.Add(this.buttonJson);
            this.Controls.Add(this.textBoxFechaNacimiento);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonTxt);
            this.Name = "StudentForm";
            this.Text = "Academy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTxt;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.TextBox textBoxFechaNacimiento;
        private System.Windows.Forms.Button buttonJson;
        private System.Windows.Forms.Button buttonXml;
        private System.Windows.Forms.Button buttonToList;
    }
}

