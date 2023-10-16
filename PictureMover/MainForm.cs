using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace PictureMover
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectSourceFolderButton_Click(object sender, EventArgs e)
        {
            // Create a FolderBrowserDialog
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                // Set the dialog title and description
                folderBrowser.Description = "Select a folder";
                folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;

                // Show the dialog and check if the user selected a folder
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Get the selected folder path
                    string selectedFolder = folderBrowser.SelectedPath;
                    SourceFolderTextBox.Text = selectedFolder;
                }
            }
        }

        private void SelectDestinationFolderButton_Click(object sender, EventArgs e)
        {
            // Create a FolderBrowserDialog
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                // Set the dialog title and description
                folderBrowser.Description = "Select a folder";
                folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;

                // Show the dialog and check if the user selected a folder
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Get the selected folder path
                    string selectedFolder = folderBrowser.SelectedPath;
                    DestinationFolderTextBox.Text = selectedFolder;
                }
            }
        }

        private void DiscoverButton_Click(object sender, EventArgs e)
        {
            int filesListed = 0;
            FileOperation.DestinationFolderStructureType destinationFolderStructureType = GetDestinationFolderStructureType();

            DataSet ds = DataSetUtils.CreateDataSet();

            FilesDataGridViewSummaryLabel.Text = "Getting File List";
            Application.DoEvents();
            var allFilePaths = FileOperation.GetAllFilePaths(SourceFolderTextBox.Text, Utils.GetListArgument(IncludeTextBox.Text), Utils.GetListArgument(ExcludeTextBox.Text));
            FilesDataGridViewSummaryLabel.Text = "File List Prepared";
            Application.DoEvents();


            FilesDataGridViewSummaryLabel.Text = "Loading File Details";
            Application.DoEvents();
            // Fill the DataTable with file data
            foreach (string filePath in allFilePaths)
            {
                //DateTime? dateTaken = FileOperation.GetDateTaken(filePath);

                FileInfo fileInfo = new FileInfo(filePath);
                string destinationFolder = FileOperation.GetDestinationFolderStructure(fileInfo.LastWriteTime, destinationFolderStructureType);
                DataRow row = ds.Tables[0].NewRow();
                row["FilePath"] = filePath;
                row["FileName"] = fileInfo.Name;
                row["Folder"] = fileInfo.DirectoryName;
                row["Date"] = fileInfo.LastWriteTime;
                row["DateTaken"] = DBNull.Value;
                row["ExistsOnDestination"] = FileOperation.IsFileExistsInDestinationWithExtension(DestinationFolderTextBox.Text, destinationFolder, filePath);
                row["Destination"] = destinationFolder;
                row["DestinationFilePath"] = "";
                row["FileCopied"] = false;

                ds.Tables[0].Rows.Add(row);
                filesListed++;

                FilesDataGridViewSummaryLabel.Text = "Loading File Details " + fileInfo.Name + " (" + filesListed.ToString() + "/" + allFilePaths.Count().ToString() + ")";
                Application.DoEvents();
            }
            FilesDataGridView.DataSource = ds.Tables[0];
            // Handle the row deletion event
            FilesDataGridView.UserDeletingRow += FilesDataGridView_UserDeletingRow;


            FilesDataGridViewSummaryLabel.Text = filesListed.ToString() + " files listed";

        }

        private FileOperation.DestinationFolderStructureType GetDestinationFolderStructureType()
        {
            /*
            2023/08-August/15/Files
            2023 / 08 - August / Files
            2023 / 08 / 15 / Files
            2023 / 08 / Files
            */

            if (DestinationFormatComboBox.SelectedIndex == 0)
            {
                return FileOperation.DestinationFolderStructureType.Year_MonthName_Day;
            }
            else if (DestinationFormatComboBox.SelectedIndex == 1)
            {
                return FileOperation.DestinationFolderStructureType.Year_MonthName;
            }
            else if (DestinationFormatComboBox.SelectedIndex == 2)
            {
                return FileOperation.DestinationFolderStructureType.Year_Month_Day;
            }
            else if (DestinationFormatComboBox.SelectedIndex == 3)
            {
                return FileOperation.DestinationFolderStructureType.Year_Month;
            }

            return FileOperation.DestinationFolderStructureType.Year_MonthName_Day;
        }

        // Event handler for row deletion
        private void FilesDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Index >= 0)
            {
                DataTable dt = (DataTable)FilesDataGridView.DataSource;
                // Get the corresponding DataRow from the DataSet
                DataRow row = dt.Rows[e.Row.Index];

                // Delete the row from the DataSet
                dt.Rows.Remove(row);
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DeleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FilterTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            FilesDataGridViewSummaryLabel.Text = "Starting File Copy";
            Application.DoEvents();

            DataTable dt = (DataTable)FilesDataGridView.DataSource;

            if(dt == null) { return; }
            if(dt.Rows.Count == 0) { return; }

            int fileCopyCount = 0;
            foreach ( DataRow row in dt.Rows )
            {
                if ((bool)row["ExistsOnDestination"] == false)
                {
                    string destinationFilePath = FileOperation.CopyFileToDestination(DestinationFolderTextBox.Text, (string)row["Destination"], (string)row["FilePath"]);
                    fileCopyCount++;
                    row["FileCopied"] = true;
                    row["DestinationFilePath"] = destinationFilePath;

                    FilesDataGridViewSummaryLabel.Text = "Coping " + (string)row["FilePath"] + " (" + fileCopyCount.ToString() + " / " + dt.Rows.Count.ToString() + ")";
                    Application.DoEvents();
                }
            }

            MessageBox.Show(fileCopyCount.ToString() + " files copied");

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DestinationFormatComboBox.SelectedIndex = 0;
        }
    }
}
