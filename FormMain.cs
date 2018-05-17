using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace Goat_s_KO_Table_Editor
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FormMain : Form
    {
		private Label label1;
		private DataGrid dataGridTable;
		private MainMenu mainMenuFormMain;
		private MenuItem menuItem1;
		private MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItemNewRow;
		private System.Windows.Forms.MenuItem menuItemNewColumn;
        private Button button1;
        private Button LoadSQL;
        private DataGrid dataGrid1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label3;
        private IContainer components;

        public FormMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.LoadSql();
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
				if (components != null) 
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridTable = new System.Windows.Forms.DataGrid();
            this.mainMenuFormMain = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItemNewRow = new System.Windows.Forms.MenuItem();
            this.menuItemNewColumn = new System.Windows.Forms.MenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.LoadSQL = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Just drag a tbl file onto the form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridTable
            // 
            this.dataGridTable.AllowDrop = true;
            this.dataGridTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridTable.DataMember = "";
            this.dataGridTable.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridTable.Location = new System.Drawing.Point(8, 53);
            this.dataGridTable.Name = "dataGridTable";
            this.dataGridTable.Size = new System.Drawing.Size(496, 136);
            this.dataGridTable.TabIndex = 1;
            this.dataGridTable.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridTable_DragDrop);
            this.dataGridTable.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridTable_DragEnter);
            // 
            // mainMenuFormMain
            // 
            this.mainMenuFormMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2});
            this.menuItem1.Text = "&File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "&Save";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemNewRow,
            this.menuItemNewColumn});
            this.menuItem3.Text = "&Edit";
            // 
            // menuItemNewRow
            // 
            this.menuItemNewRow.Index = 0;
            this.menuItemNewRow.Text = "New &Row At Cursor";
            this.menuItemNewRow.Click += new System.EventHandler(this.menuItemNewRow_Click);
            // 
            // menuItemNewColumn
            // 
            this.menuItemNewColumn.Index = 1;
            this.menuItemNewColumn.Text = "New &Column";
            this.menuItemNewColumn.Click += new System.EventHandler(this.menuItemNewColumn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoadSQL
            // 
            this.LoadSQL.Location = new System.Drawing.Point(12, 24);
            this.LoadSQL.Name = "LoadSQL";
            this.LoadSQL.Size = new System.Drawing.Size(75, 23);
            this.LoadSQL.TabIndex = 3;
            this.LoadSQL.Text = "button2";
            this.LoadSQL.UseVisualStyleBackColor = true;
            this.LoadSQL.Click += new System.EventHandler(this.LoadSql_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.AllowDrop = true;
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(8, 204);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(496, 87);
            this.dataGrid1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Column From SQL";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 351);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.SqlColumSelector_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Column From Tbl File";
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(512, 373);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.LoadSQL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridTable);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenuFormMain;
            this.Name = "FormMain";
            this.Text = "GoatCheez\'s KO TBL Editor";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void FormMain_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent(System.Windows.Forms.DataFormats.FileDrop))
			{
				e.Effect = System.Windows.Forms.DragDropEffects.Copy;
			}
		}

		private const string WindowTitle = "Goat's KO TBL Viewer";

		private byte[] LoadAndDecodeFile(string fileName)
		{
			System.IO.FileStream readStream = new System.IO.FileStream(fileName,System.IO.FileMode.Open,System.IO.FileAccess.Read);
			byte[] fileData = null;
			int bytesRead = 0;
			for (fileData = new byte[readStream.Length]; bytesRead < readStream.Length; bytesRead += readStream.Read(fileData,bytesRead,(int)(readStream.Length - bytesRead)));
			readStream.Close();

			uint modWord = 0x0816;
			for (int i = 0; i < fileData.Length; i++)
			{
				byte encodedByte = fileData[i];
				uint tmpModWord = modWord;
				byte decodedByte = 0;

				tmpModWord &= 0xff00;
				tmpModWord = tmpModWord >> 8;
				decodedByte = (byte)(tmpModWord ^ encodedByte);
				tmpModWord = encodedByte;
				tmpModWord += modWord;
				tmpModWord = tmpModWord & 0xffff; //eliminate overflow
				tmpModWord = tmpModWord * 0x6081;
				tmpModWord = tmpModWord & 0xffff; //eliminate overflow
				tmpModWord += 0x1608;
				tmpModWord = tmpModWord & 0xffff; //eliminate overflow
				modWord = tmpModWord;

				fileData[i] = decodedByte;				
			}
			return fileData;
		}

        private TblFileOperations tblFileOperations = new TblFileOperations();

		private string currentTableFileName = "";
		private System.Data.DataSet	currentTableDataSet = null;

		private void FormMain_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			string[] theFiles = (string[])e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop);
			//(we only use the first one... one table at a time ppl!)
			string theDataFile = theFiles[0];

            if (tblFileOperations.LoadByteDataIntoView(LoadAndDecodeFile(theDataFile)))
			{
                SetDataGridTableView(tblFileOperations.TableDataSet);
                this.Text = WindowTitle + " - " + theDataFile;
				currentTableFileName = theDataFile;
			}
		}

        private void SetDataGridTableView(DataSet tableDataSet)
        {
            dataGridTable.SuspendLayout();

            dataGridTable.SetDataBinding(tableDataSet, "tableDataTable");

            dataGridTable.ResumeLayout();
            if (currentTableDataSet != null)
            {
                currentTableDataSet.Dispose();
                currentTableDataSet = null;
            }

            currentTableDataSet = tableDataSet;
        }

        private void menuItem2_Click(object sender, System.EventArgs e)
		{
			if ((currentTableFileName == "") || (!System.IO.File.Exists(currentTableFileName)) || (currentTableDataSet == null))
			{
				System.Windows.Forms.MessageBox.Show("Error - No table to save");
				return;
			}

            DataTable theTable = currentTableDataSet.Tables["tableDataTable"];

			if (theTable == null)
			{
				System.Windows.Forms.MessageBox.Show("Error - Main table is null.");
				return;
			}

			var outStream = new System.IO.FileStream(currentTableFileName, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite, System.IO.FileShare.None);
            outStream.Write(BitConverter.GetBytes(theTable.Columns.Count),0,4);
			var column = 0;

			for (column = 0; column < theTable.Columns.Count; column++)
			{
				switch (theTable.Columns[column].DataType.FullName)
				{
					case "System.Single":
						outStream.Write(BitConverter.GetBytes((int)8),0,4);						
						break;
					case "System.String":
						outStream.Write(BitConverter.GetBytes((int)7),0,4);						
						break;
					case "System.UInt32":
						outStream.Write(BitConverter.GetBytes((int)6),0,4);						
						break;
					case "System.Int32":
						outStream.Write(BitConverter.GetBytes((int)5),0,4);						
						break;
					case "System.Int16":
						outStream.Write(BitConverter.GetBytes((int)3),0,4);						
						break;
					case "System.Byte":
						outStream.Write(BitConverter.GetBytes((int)2),0,4);						
						break;
					case "System.SByte":
						outStream.Write(BitConverter.GetBytes((int)1),0,4);						
						break;
					default:
						outStream.Write(BitConverter.GetBytes((int)5),0,4);						
						break;
				}
			}
			outStream.Write(BitConverter.GetBytes((int)theTable.Rows.Count),0,4);
			for (int row = 0; row < theTable.Rows.Count; row++)
			{
				object[] theRowData = theTable.Rows[row].ItemArray;
				for (column = 0; column < theTable.Columns.Count; column++)
				{
					switch (theTable.Columns[column].DataType.FullName)
					{
						case "System.Single":
							outStream.Write(BitConverter.GetBytes((System.Single)theRowData[column]),0,4);
							break;
						case "System.String":
							string theString = (string)theRowData[column];
							if ((theString == null) || (theString.Length == 0))
							{
								outStream.Write(BitConverter.GetBytes((int)0),0,4);
								break;
							}							
							outStream.Write(BitConverter.GetBytes((int)theString.Length),0,4);
							for (int i = 0; i < theString.Length; i++)
							{
								outStream.WriteByte((byte)theString[i]);
							}
							break;
						case "System.UInt32":
							outStream.Write(BitConverter.GetBytes((System.UInt32)theRowData[column]),0,4);
							break;
						case "System.Int32":
							outStream.Write(BitConverter.GetBytes((System.Int32)theRowData[column]),0,4);
							break;
						case "System.Int16":
							outStream.Write(BitConverter.GetBytes((System.Int16)theRowData[column]),0,2);
							break;
						case "System.Byte":
							outStream.Write(BitConverter.GetBytes((System.Byte)theRowData[column]),0,1);
							break;
						case "System.SByte":
							outStream.Write(BitConverter.GetBytes((System.SByte)theRowData[column]),0,1);
							break;
						default:
							outStream.Write(BitConverter.GetBytes((System.Int32)theRowData[column]),0,4);
							break;
					}
				}
			}
			outStream.Seek(0,System.IO.SeekOrigin.Begin);
			int inVal = outStream.ReadByte();
			uint modWord = 0x0816;
			while (inVal != -1)
			{
				outStream.Seek(-1,System.IO.SeekOrigin.Current);
				byte inByte = (byte)(inVal & 0xff);
				byte outByte = 0;

				uint tmpModWord = modWord;
				tmpModWord &= 0xff00;
				tmpModWord = tmpModWord >> 8;
				outByte = (byte)(tmpModWord ^ inByte);
				tmpModWord = outByte;
				//tmpModWord = tmpModWord ^ tmpModWord;
				//tmpModWord = (tmpModWord & 0xff00) | outByte;
				tmpModWord += modWord;
				tmpModWord = tmpModWord & 0xffff; //eliminate overflow
				tmpModWord = tmpModWord * 0x6081;
				tmpModWord = tmpModWord & 0xffff; //eliminate overflow
				tmpModWord += 0x1608;
				tmpModWord = tmpModWord & 0xffff; //eliminate overflow
				modWord = tmpModWord;

				outStream.WriteByte(outByte);
				inVal = outStream.ReadByte();
			}

			outStream.Close();			
		}

		private void dataGridTable_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{			
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void dataGridTable_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			string[] theFiles = (string[])e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop);
			//(we only use the first one... one table at a time ppl!)
			string theDataFile = theFiles[0];
            var tableDataSet = new DataSet();

            if (tblFileOperations.LoadByteDataIntoView(LoadAndDecodeFile(theDataFile)))
			{
                SetDataGridTableView(tblFileOperations.TableDataSet);
                this.Text = WindowTitle + " - " + theDataFile;
				currentTableFileName = theDataFile;
			}
		}

		private void menuItemNewColumn_Click(object sender, System.EventArgs e)
		{
			if ((currentTableFileName == "") || (!System.IO.File.Exists(currentTableFileName)) || (currentTableDataSet == null))
			{
				System.Windows.Forms.MessageBox.Show("Error - No table to operate on");
				return;
			}
			System.Data.DataTable theTable = currentTableDataSet.Tables["tableDataTable"];
			if (theTable == null)
			{
				System.Windows.Forms.MessageBox.Show("Error - Main table is null.");
				return;
			}
			ColumnCreationForm columnCreationOptionsForm = new ColumnCreationForm();
			if (columnCreationOptionsForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				System.Type dataType = typeof(System.Int32);
				object defaultValue = null;
				string typeString = "";
				switch (columnCreationOptionsForm.DataTypeIndex)
				{
					case 0:
						dataType = typeof(System.Single);
						defaultValue = Convert.ToSingle(columnCreationOptionsForm.DataDefaultValue);
						typeString = "Float";
						break;
					case 1:
						dataType = typeof(System.String);
						defaultValue = columnCreationOptionsForm.DataDefaultValue;
						typeString = "String";
						break;
					case 2:
						dataType = typeof(System.UInt32);
						defaultValue = Convert.ToUInt32(columnCreationOptionsForm.DataDefaultValue);
						typeString = "UInt32";
						break;
					case 3:
						dataType = typeof(System.Int32);
						defaultValue = Convert.ToInt32(columnCreationOptionsForm.DataDefaultValue);
						typeString = "Int32";
						break;
					case 4:
						dataType = typeof(System.Int16);
						typeString = "Int16";
						defaultValue = Convert.ToInt16(columnCreationOptionsForm.DataDefaultValue);
						break;
					case 5:
						dataType = typeof(System.Byte);
						defaultValue = Convert.ToByte(columnCreationOptionsForm.DataDefaultValue,10);
						typeString = "Byte";
						break;
					case 6:
						dataType = typeof(System.SByte);
						defaultValue = Convert.ToSByte(columnCreationOptionsForm.DataDefaultValue,10);
						typeString = "SByte";
						break;					
				}
				int columnCount = theTable.Columns.Count;
				System.Data.DataColumn newColumn = new DataColumn(columnCount.ToString() + " - New - " + typeString,dataType);		
				newColumn.DefaultValue = defaultValue;				
				theTable.Columns.Add(newColumn);	
				theTable.AcceptChanges();
			}
		}

		private void menuItemNewRow_Click(object sender, System.EventArgs e)
		{
			if ((currentTableFileName == "") || (!System.IO.File.Exists(currentTableFileName)) || (currentTableDataSet == null))
			{
				System.Windows.Forms.MessageBox.Show("Error - No table to operate on");
				return;
			}
			System.Data.DataTable theTable = currentTableDataSet.Tables["tableDataTable"];
			if (theTable == null)
			{
				System.Windows.Forms.MessageBox.Show("Error - Main table is null.");
				return;
			}
			
			int currentIndex = dataGridTable.CurrentCell.RowNumber;	
			System.Data.DataRow newRow = theTable.NewRow();		
			for (int column = 0; column < theTable.Columns.Count; column++)
			{
				newRow[column] = theTable.Columns[column].DefaultValue;
			}
			theTable.Rows.InsertAt(newRow,currentIndex);
			theTable.AcceptChanges();
		}

		private void FormMain_Load(object sender, System.EventArgs e)
		{
			if (Environment.GetCommandLineArgs().Length > 1)
			{
				string[] args = Environment.GetCommandLineArgs();
				if (System.IO.File.Exists(args[1]))
				{
					if (tblFileOperations.LoadByteDataIntoView(LoadAndDecodeFile(args[1])))
					{
						this.Text = WindowTitle + " - " + args[1];
						currentTableFileName = args[1];
					} 
					else 
					{
                        MessageBox.Show("Unable to load file: " + args[1]);
					}
				} 
				else 
				{
                    MessageBox.Show("Error - " + args[1] + " does not exist.");
				}
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridTable.ColumnHeadersVisible = true;
            var columnsNumber = currentTableDataSet.Tables["tableDataTable"].Columns.Count;
            var rawsNumber = currentTableDataSet.Tables["tableDataTable"].Rows.Count;

            for (int raw = 0; raw < rawsNumber; raw++)
            {
                currentTableDataSet.Tables["tableDataTable"].Rows[raw][15] = (Int16)((Int16)currentTableDataSet.Tables["tableDataTable"].Rows[raw][15]* 0.25);
            }

            menuItem2_Click(sender, e);
        }

        DataTable dataTableItem = null;

        private void LoadSql()
        {
            dataTableItem = DataBaseFunctionality.Sql();
            dataGrid1.SuspendLayout();
            dataGrid1.DataSource = DataBaseFunctionality.DataSetItem.Tables[0];

            dataGrid1.ResumeLayout();
            if (currentTableDataSet2 != null)
            {
                currentTableDataSet2.Dispose();
                currentTableDataSet2 = null;
            }

            currentTableDataSet2 = (DataBaseFunctionality.DataSetItem);

            dataGrid1.RowHeadersVisible = true;
            dataGrid1.ColumnHeadersVisible = true;

            var columnNames = new List<string>();

            foreach (DataColumn column in dataTableItem.Columns)
            {
                columnNames.Add(column.ColumnName);
            }

            comboBox1.DataSource = columnNames;
        }

        private void LoadSql_Click(object sender, EventArgs e)
        {
            int columnNumber = dataGridTable.CurrentCell.ColumnNumber;
            var rawsNumber = currentTableDataSet.Tables["tableDataTable"].Rows.Count;

            IDictionary<long, Tuple<int, Int16>> weapons = new Dictionary<long, Tuple<int, Int16>>();

            for (int raw = 0; raw < rawsNumber; raw++)
            {
                var weaponId = currentTableDataSet.Tables["tableDataTable"].Rows[raw][0];
                var weaponAttack = currentTableDataSet.Tables["tableDataTable"].Rows[raw][15];
                weapons.Add((UInt32)weaponId, new Tuple<int, Int16>(raw, (Int16)weaponAttack));
            }

            var dataTableEnumerable = dataTableItem.AsEnumerable();

            var itemNumIdentifier = from products in dataTableEnumerable select products.Field<Int32>("Num");
            var weaponAp = from products in dataTableEnumerable select products.Field<Int16>(SqlDataBaseColum);
            var itemNumIdentifiers = itemNumIdentifier.ToList();
            var weaponsAp = weaponAp.ToList();
            IDictionary<long, Int16> weaponsFromDb = new Dictionary<long, Int16>();

            var i = 0;
            foreach (var item in itemNumIdentifiers)
            {
                weaponsFromDb.Add(item, weaponsAp.ElementAt(i));
                i++;
            }

            var dd = dataTableEnumerable.Where(x => weapons.ContainsKey((UInt32)x.ItemArray[0])).Select(x => x.ItemArray);
            int debug = 0;
            foreach (var dupa in weapons)
            {
                try
                {
                    debug++;
                    currentTableDataSet.Tables["tableDataTable"].Rows[dupa.Value.Item1][15] = weaponsFromDb[dupa.Key];
                }
                catch (Exception ex)
                {
                    string dypa = "Key not exist in DB";
                }
            }
        }

        private void SqlColumSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            SqlDataBaseColum = (string)comboBox1.SelectedItem;
        }

        private string SqlDataBaseColum;
        private System.Data.DataSet currentTableDataSet2 = null;
    }
}
