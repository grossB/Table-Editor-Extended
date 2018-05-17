using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goat_s_KO_Table_Editor
{
    public class TblFileOperations
    {
        public DataSet TableDataSet { get; set; }

        public bool LoadByteDataIntoView(byte[] fileData )
        {
            int theIndex = 0;
            int columnCount = BitConverter.ToInt32(fileData, theIndex);
            if ((columnCount < 0) || (((columnCount * 4) + (columnCount * 1)) > fileData.Length))
            {
                System.Windows.Forms.MessageBox.Show("Not a standard tbl file.");
                return false;
            }
            theIndex += 4;
            int[] columnIds = new int[columnCount];
            TableDataSet = new DataSet("tableDataSet");
            DataTable tableDataTable = new System.Data.DataTable("tableDataTable");
            for (int i = 0; i < columnCount; i++)
            {
                int columnId = BitConverter.ToInt32(fileData, theIndex);
                columnIds[i] = columnId;
                System.Data.DataColumn dataColumn;
                switch (columnId)
                {
                    case 8:
                        dataColumn = new System.Data.DataColumn(i.ToString() + " - Float", typeof(System.Single));
                        dataColumn.DefaultValue = (float)0.0;
                        break;
                    case 7:
                        dataColumn = new System.Data.DataColumn(i.ToString() + " - String", typeof(System.String));
                        dataColumn.DefaultValue = "";
                        break;
                    case 6:
                        dataColumn = new System.Data.DataColumn(i.ToString() + " - UInt32", typeof(System.UInt32));
                        dataColumn.DefaultValue = (uint)0;
                        break;
                    case 5:
                        dataColumn = new System.Data.DataColumn(i.ToString() + " - Int32", typeof(System.Int32));
                        dataColumn.DefaultValue = (int)0;
                        break;
                    case 3:
                        dataColumn = new System.Data.DataColumn(i.ToString() + " - Int16", typeof(System.Int16));
                        dataColumn.DefaultValue = (short)0;
                        break;
                    case 2:
                        dataColumn = new System.Data.DataColumn(i.ToString() + " - Byte", typeof(System.Byte));
                        dataColumn.DefaultValue = (byte)0;
                        break;
                    case 1:
                        dataColumn = new System.Data.DataColumn(i.ToString() + " - SByte", typeof(System.SByte));
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

            TableDataSet.Tables.Add(tableDataTable);
            int rowCount = BitConverter.ToInt32(fileData, theIndex);
            theIndex += 4;
            for (int row = 0; (row < rowCount) && (theIndex < fileData.Length); row++)
            {
                System.Data.DataRow newRow = tableDataTable.NewRow();
                for (int column = 0; (column < columnCount) && (theIndex < fileData.Length); column++)
                {
                    switch (columnIds[column])
                    {
                        case 8:
                            newRow[column] = BitConverter.ToSingle(fileData, theIndex);
                            theIndex += 4;
                            break;
                        case 7:
                            //newRow[column] = BitConverter.ToString(
                            //dataColumn = new System.Data.DataColumn(i.ToString() + " - String",typeof(System.String));						
                            int stringLength = BitConverter.ToInt32(fileData, theIndex);
                            theIndex += 4;
                            char[] newString = new char[stringLength];
                            for (int stri = 0; stri < stringLength; stri++)
                            {
                                newString[stri] = (char)fileData[theIndex];
                                theIndex++;
                            }
                            newRow[column] = new String(newString);
                            break;
                        case 6:
                            newRow[column] = BitConverter.ToUInt32(fileData, theIndex);
                            theIndex += 4;
                            break;
                        case 5:
                            newRow[column] = BitConverter.ToInt32(fileData, theIndex);
                            theIndex += 4;
                            break;
                        case 3:
                            newRow[column] = BitConverter.ToInt16(fileData, theIndex);
                            theIndex += 2;
                            break;
                        case 2:
                            newRow[column] = fileData[theIndex];
                            theIndex += 1;
                            break;
                        case 1:
                            newRow[column] = (fileData[theIndex] > 127) ? fileData[theIndex] - 256 : fileData[theIndex];
                            theIndex += 1;
                            break;
                        default:
                            newRow[column] = BitConverter.ToInt32(fileData, theIndex);
                            theIndex += 4;
                            break;
                    }
                }
                tableDataTable.Rows.Add(newRow);
            }

            return true;
        }
    }
}
