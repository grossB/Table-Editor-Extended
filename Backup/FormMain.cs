using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Goat_s_KO_Table_Editor
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FormMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGrid dataGridTable;
		private System.Windows.Forms.MainMenu mainMenuFormMain;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItemNewRow;
		private System.Windows.Forms.MenuItem menuItemNewColumn;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormMain()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormMain));
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridTable = new System.Windows.Forms.DataGrid();
			this.mainMenuFormMain = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItemNewRow = new System.Windows.Forms.MenuItem();
			this.menuItemNewColumn = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).BeginInit();
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
			this.dataGridTable.Location = new System.Drawing.Point(8, 32);
			this.dataGridTable.Name = "dataGridTable";
			this.dataGridTable.Size = new System.Drawing.Size(496, 328);
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
			// FormMain
			// 
			this.AllowDrop = true;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 373);
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
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FormMain());
		}

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

		private bool LoadByteDataIntoView(byte[] fileData)
		{
			int theIndex = 0;
			int columnCount = BitConverter.ToInt32(fileData,theIndex);
			if ((columnCount < 0) || (((columnCount * 4) + (columnCount * 1)) > fileData.Length))
			{
				System.Windows.Forms.MessageBox.Show("Not a standard tbl file.");
				return false;
			}
			theIndex += 4;
			int[] columnIds = new int[columnCount];
			System.Data.DataSet tableDataSet = new DataSet("tableDataSet");
			System.Data.DataTable tableDataTable = new System.Data.DataTable("tableDataTable");
			for (int i = 0; i < columnCount; i++)
			{
				int columnId = BitConverter.ToInt32(fileData,theIndex);
				columnIds[i] = columnId;
				System.Data.DataColumn dataColumn;
				switch (columnId)
				{		
					case 8:
						dataColumn = new System.Data.DataColumn(i.ToString() + " - Float",typeof(System.Single));
						dataColumn.DefaultValue = (float)0.0;
						break;
					case 7:
						dataColumn = new System.Data.DataColumn(i.ToString() + " - String",typeof(System.String));						
						dataColumn.DefaultValue = "";
						break;
					case 6:
						dataColumn = new System.Data.DataColumn(i.ToString() + " - UInt32",typeof(System.UInt32));						
						dataColumn.DefaultValue = (uint)0;
						break;
					case 5:
						dataColumn = new System.Data.DataColumn(i.ToString() + " - Int32",typeof(System.Int32));						
						dataColumn.DefaultValue = (int)0;
						break;
					case 3:
						dataColumn = new System.Data.DataColumn(i.ToString() + " - Int16",typeof(System.Int16));						
						dataColumn.DefaultValue = (short)0;
						break;
					case 2:
						dataColumn = new System.Data.DataColumn(i.ToString() + " - Byte",typeof(System.Byte));						
						dataColumn.DefaultValue = (byte)0;
						break;
					case 1:
						dataColumn = new System.Data.DataColumn(i.ToString() + " - SByte",typeof(System.SByte));						
						dataColumn.DefaultValue = (sbyte)0;
						break;
					default:
						dataColumn = new System.Data.DataColumn(i.ToString() + " - ? - " + columnId.ToString());												
						dataColumn.DefaultValue = (int)0;
						break;
				}
				tableDataTable.Columns.Add(dataColumn);
				theIndex += 4;
			}
			tableDataSet.Tables.Add(tableDataTable);
			int rowCount = BitConverter.ToInt32(fileData,theIndex);
			theIndex += 4;
			for (int row = 0; (row < rowCount) && (theIndex < fileData.Length); row++)
			{
				System.Data.DataRow newRow = tableDataTable.NewRow();
				for (int column = 0; (column < columnCount) && (theIndex < fileData.Length); column++)
				{					
					switch (columnIds[column])
					{
						case 8:
							newRow[column] = BitConverter.ToSingle(fileData,theIndex);
							theIndex += 4;
							break;
						case 7:
							//newRow[column] = BitConverter.ToString(
							//dataColumn = new System.Data.DataColumn(i.ToString() + " - String",typeof(System.String));						
							int stringLength = BitConverter.ToInt32(fileData,theIndex);
							theIndex += 4;
							char[] newString = new char[stringLength];
							for (int stri  = 0; stri < stringLength; stri++)
							{
								newString[stri] = (char)fileData[theIndex];
								theIndex++;
							}  
							newRow[column] = new String(newString);
							break;
						case 6:
							newRow[column] = BitConverter.ToUInt32(fileData,theIndex);
							theIndex += 4;							
							break;
						case 5:
							newRow[column] = BitConverter.ToInt32(fileData,theIndex);
							theIndex += 4;							
							break;
						case 3:
							newRow[column] = BitConverter.ToInt16(fileData,theIndex);
							theIndex += 2;							
							break;
						case 2:
							newRow[column] = fileData[theIndex];
							theIndex += 1;							
							break;
						case 1:
							newRow[column] = (fileData[theIndex] > 127)?fileData[theIndex] - 256:fileData[theIndex];
							theIndex += 1;							
							break;
						default:
							newRow[column] = BitConverter.ToInt32(fileData,theIndex);
							theIndex += 4;							
							break;						
					}
				}
				tableDataTable.Rows.Add(newRow);
			}	
			
			dataGridTable.SuspendLayout();
						
			dataGridTable.SetDataBinding(tableDataSet,"tableDataTable");
			
			dataGridTable.ResumeLayout();	
			if (currentTableDataSet != null)
			{
				currentTableDataSet.Dispose();
				currentTableDataSet = null;
			}
			currentTableDataSet = tableDataSet;
			return true;
		}		

		private string currentTableFileName = "";
		private System.Data.DataSet	currentTableDataSet = null;

		private void FormMain_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			string[] theFiles = (string[])e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop);
			//(we only use the first one... one table at a time ppl!)
			string theDataFile = theFiles[0];

			if (LoadByteDataIntoView(LoadAndDecodeFile(theDataFile)))
			{
				this.Text = WindowTitle + " - " + theDataFile;
				currentTableFileName = theDataFile;
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			if ((currentTableFileName == "") || (!System.IO.File.Exists(currentTableFileName)) || (currentTableDataSet == null))
			{
				System.Windows.Forms.MessageBox.Show("Error - No table to save");
				return;
			}
			System.Data.DataTable theTable = currentTableDataSet.Tables["tableDataTable"];
			if (theTable == null)
			{
				System.Windows.Forms.MessageBox.Show("Error - Main table is null.");
				return;
			}
			System.IO.FileStream outStream = new System.IO.FileStream(currentTableFileName, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite, System.IO.FileShare.None);
			outStream.Write(BitConverter.GetBytes(theTable.Columns.Count),0,4);
			int column = 0;
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
			if (e.Data.GetDataPresent(System.Windows.Forms.DataFormats.FileDrop))
			{
				e.Effect = System.Windows.Forms.DragDropEffects.Copy;
			}
		}

		private void dataGridTable_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			string[] theFiles = (string[])e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop);
			//(we only use the first one... one table at a time ppl!)
			string theDataFile = theFiles[0];

			if (LoadByteDataIntoView(LoadAndDecodeFile(theDataFile)))
			{
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
					if (LoadByteDataIntoView(LoadAndDecodeFile(args[1])))
					{
						this.Text = WindowTitle + " - " + args[1];
						currentTableFileName = args[1];
					} 
					else 
					{
						System.Windows.Forms.MessageBox.Show("Unable to load file: " + args[1]);
					}
				} 
				else 
				{
					System.Windows.Forms.MessageBox.Show("Error - " + args[1] + " does not exist.");
				}
			}
		}
	}
}
