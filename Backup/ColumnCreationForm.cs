using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Goat_s_KO_Table_Editor
{
	/// <summary>
	/// Summary description for ColumnCreationForm.
	/// </summary>
	public class ColumnCreationForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ComboBox comboBoxDataTypes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.TextBox textBoxDefaultValue;
		private System.Windows.Forms.Label label2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ColumnCreationForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBoxDataTypes = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.textBoxDefaultValue = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboBoxDataTypes
			// 
			this.comboBoxDataTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDataTypes.Items.AddRange(new object[] {
																   "Float",
																   "String",
																   "UInt32",
																   "Int32",
																   "Int16",
																   "Byte",
																   "SByte"});
			this.comboBoxDataTypes.Location = new System.Drawing.Point(112, 8);
			this.comboBoxDataTypes.Name = "comboBoxDataTypes";
			this.comboBoxDataTypes.Size = new System.Drawing.Size(144, 21);
			this.comboBoxDataTypes.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Data Type:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(152, 80);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(96, 32);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "OK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(16, 80);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(96, 32);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// textBoxDefaultValue
			// 
			this.textBoxDefaultValue.Location = new System.Drawing.Point(112, 40);
			this.textBoxDefaultValue.Name = "textBoxDefaultValue";
			this.textBoxDefaultValue.Size = new System.Drawing.Size(144, 20);
			this.textBoxDefaultValue.TabIndex = 4;
			this.textBoxDefaultValue.Text = "0";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Default Value:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ColumnCreationForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(264, 125);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxDefaultValue);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxDataTypes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ColumnCreationForm";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Column Properties";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.ColumnCreationForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void ColumnCreationForm_Load(object sender, System.EventArgs e)
		{
			comboBoxDataTypes.SelectedIndex = 3;		
		}

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Hide();
		}

		public int DataTypeIndex
		{
			get
			{
				return comboBoxDataTypes.SelectedIndex;
			}
		}

		public string DataDefaultValue
		{
			get
			{
				return textBoxDefaultValue.Text;
			}
		}

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Hide();
		}
	}
}
