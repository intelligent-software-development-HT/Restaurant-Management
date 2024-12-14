using DTO;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL
{
   public  class WordExport
    {
        #region ---- Constants & Enum -----

        
        private const string FILE_QUYETDINHKHENTHUONG = "BM11";
         

        #endregion

        #region --- Member Variables ----

        private bool _IsPringPriview = false;

        #endregion

        #region --- Private medthods ---

         
        /// PrinPreview the document
        /// </summary>
        /// <param name="fileToPrint"></param>
        private void PrinPriview(string fileToPrint)
        {
            object missing = System.Type.Missing;
            object objFile = fileToPrint;
            object readOnly = true;
            object addToRecentOpen = false;

            // Create  a new Word application           
            Microsoft.Office.Interop.Word._Application wordApplication = new Microsoft.Office.Interop.Word.Application();
            try
            {
                // Create a new file based on our template
                Microsoft.Office.Interop.Word._Document wordDocument = wordApplication.Documents.Open(ref objFile, ref missing, ref readOnly, ref addToRecentOpen);

                wordApplication.Options.SaveNormalPrompt = false;

                if (wordDocument != null)
                {
                    // Show print preview
                    wordApplication.Visible = true;
                    wordDocument.PrintPreview();
                    wordDocument.Activate();
                    //wordDocument.op
                    while (!_IsPringPriview)
                    {
                        wordDocument.ActiveWindow.View.Magnifier = true;
                        Thread.Sleep(500);
                    }

                    wordDocument.Close(ref missing, ref missing, ref missing);
                    wordDocument = null;
                }
            }
            catch
            {
                //I didn't include a default error handler so i'm just throwing the error
                // throw ex;
            }
            finally
            {
                // Finally, Close our Word application
                wordApplication.Quit(ref missing, ref missing, ref missing);
                wordApplication = null;
            }
        }

        /// <summary>
        /// Manage WordExport_DocumentBeforeClose
        /// </summary>
        /// <param name="Doc"></param>
        /// <param name="Cancel"></param>
        private void WordExport_DocumentBeforeClose(Microsoft.Office.Interop.Word.Document Doc, ref bool Cancel)
        {
            _IsPringPriview = false;
        }

        /// <summary>
        /// Merges the specified files to merge.
        /// </summary>
        /// <param name="filesToMerge">The files to merge.</param>
        /// <param name="outputFilename">The output filename.</param>
        /// <param name="insertPageBreaks">if set to <c>true</c> [insert page breaks].</param>
        private void Merge(string[] filesToMerge, string outputFilename, bool insertPageBreaks)
        {
            string fileTempate = Global.AppPath + Constants.FOLDER_TEMPLATES +
                                 Constants.CHAR_FLASH + Constants.FILE_NORMAL_DOT;
            Merge(filesToMerge, outputFilename, insertPageBreaks, fileTempate);
        }

        /// <summary>
        /// A function that merges Microsoft Word Documents that uses a template specified by the user
        /// </summary>
        /// <param name="filesToMerge">An array of files that we want to merge</param>
        /// <param name="outputFilename">The filename of the merged document</param>
        /// <param name="insertPageBreaks">Set to true if you want to have page breaks inserted after each document</param>
        /// <param name="documentTemplate">The word document you want to use to serve as the template</param>
        private void Merge(string[] filesToMerge, string outputFilename, bool insertPageBreaks, string documentTemplate)
        {
            object defaultTemplate = documentTemplate;
            object missing = System.Type.Missing;
            object pageBreak = Microsoft.Office.Interop.Word.WdBreakType.wdPageBreak;
            object outputFile = outputFilename;

            // Create  a new Word application
            Microsoft.Office.Interop.Word._Application wordApplication = new Microsoft.Office.Interop.Word.Application();
            if (filesToMerge.Count() == 1)
                pageBreak = false;
            try
            {
                // Create a new file based on our template
                Microsoft.Office.Interop.Word._Document wordDocument = wordApplication.Documents.Add(ref defaultTemplate, ref missing, ref missing, ref missing);

                // Make a Word selection object.
                Microsoft.Office.Interop.Word.Selection selection = wordApplication.Selection;

                int index = 0;

                // Loop thru each of the Word documents
                foreach (string file in filesToMerge)
                {
                    // Insert the files to our template
                    selection.InsertFile(file, ref missing, ref missing, ref missing, ref missing);

                    //Do we want page breaks added after each documents?
                    if (insertPageBreaks && index != filesToMerge.Count() - 1)
                    {
                        selection.InsertBreak(ref pageBreak);
                    }

                    index++;
                }

                // Save the document to it's output file.
                wordDocument.SaveAs(ref outputFile, ref missing, ref missing, ref missing, ref missing,
                                     ref missing, ref missing, ref missing, ref missing, ref missing,
                                     ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);

                // Clean up!
                wordDocument.Close(ref missing, ref missing, ref missing);
                wordDocument = null;
            }
            catch (Exception ex)
            {
                //I didn't include a default error handler so i'm just throwing the error
                throw ex;
            }
            finally
            {
                // Finally, Close our Word application
                wordApplication.Quit(ref missing, ref missing, ref missing);
            }
        }

        /// <summary>
        /// Page setup the word document
        /// </summary>
        /// <param name="document"></param>
        private void PageSetup(ref WordDocument document)
        {
            foreach (WSection section in document.Sections)
            {

                // Setting Page Margins
                section.PageSetup.Margins.Top = 72f;
                section.PageSetup.Margins.Bottom = 90f;
                section.PageSetup.Margins.Left = 72f;
                section.PageSetup.Margins.Right = 72f;

                section.PageSetup.HeaderDistance = 1;
                section.PageSetup.FooterDistance = 1;

                //Setup page size
                section.PageSetup.PageSize = PageSize.A4;

                // Setting the Page Orientation as Portrait or Landscape
                section.PageSetup.Orientation = PageOrientation.Landscape;
            }
        }

        #endregion

        public void HoaDonBanHang(int maHoaDon, string ngayTao, string tenBan, string tenNhanVien, int tongTien, List<ChiTietHoaDon> chiTietHoaDons)
        {
            #region ===== Core======
            MemoryStream mStream = null;
            WordDocument document = null;
            string fileBoNhiem = string.Empty;
            // Create currency format
            CultureInfo vietnam = new CultureInfo(1066);
            NumberFormatInfo vnfi = vietnam.NumberFormat;
            vnfi.CurrencySymbol = Constants.VN_UNIT;
            vnfi.CurrencyDecimalSeparator = Constants.CHAR_COMMA;
            vnfi.CurrencyDecimalDigits = 0;
            //Create Temp Folder if it does not exist
            if (!Directory.Exists(Global.AppPath + Constants.FOLDER_TEMP))
            {
                Directory.CreateDirectory(Global.AppPath + Constants.FOLDER_TEMP);
            }
            //Gets DocFile is Existed
            string[] DocFile = Directory.GetFiles(Global.AppPath + Constants.FOLDER_TEMP +
                        Constants.CHAR_FLASH, Constants.CHAR_STAR + Constants.FILE_EXT_DOC);
            //Delete *.doc file if existed
            foreach (string file in DocFile)
            {
                File.Delete(file);
            }
            string fileName = Path.Combine("hoa-don-thanh-toan.docx");
            string path = Global.AppPath + fileName;
            try
            {
                // Read template
                //mStream = new MemoryStream(File.ReadAllBytes("hoa-don-thanh-toan.docx").ToArray());// I
                mStream = new MemoryStream(File.ReadAllBytes(path).ToArray());// I
                document = new WordDocument(mStream);
                mStream.Close();
            }
            catch
            {
                
                return;
            }

            fileBoNhiem = Global.AppPath + Constants.FOLDER_TEMP +
                            Constants.CHAR_FLASH + "hoa-don-thanh-toan" + Constants.FILE_EXT_DOC;// II

            //Prepare to mailMerg
            DateTime SysDate = DateTime.Now;
            #endregion =====  End Core=====

            #region === Set value =====//III

            string[] fields = new string[] { "MaHoaDon", "NgayTao", "TenBan", "TenNhanVien", "TongTien" };


            string[] values = new string[] { maHoaDon.ToString(), ngayTao, tenBan, tenNhanVien, tongTien.ToString("N0") };

            #endregion End Set Value=====

            #region =====Core=====
            // Begin mailMerg document
            document.MailMerge.Execute(fields, values);

            // Lấy bảng mẫu trong tài liệu Word
            WTable table = document.Sections[0].Tables[0] as WTable;

            // Chèn từng dòng dữ liệu vào bảng
            foreach (var item in chiTietHoaDons)
            {
                WTableRow row = table.AddRow(true); // Thêm một hàng mới vào bảng
                //row.Cells[0].AddParagraph().AppendText(item.MonAn.TenMonAn.ToString());
                //row.Cells[1].AddParagraph().AppendText(item.SoLuong.ToString());
                //row.Cells[2].AddParagraph().AppendText(item.MonAn.DonGia?.ToString("N0"));
                //row.Cells[3].AddParagraph().AppendText(item.ThanhTien?.ToString("N0"));

                // Cột "Tên món"
                var cell0 = row.Cells[0];
                var paragraph0 = cell0.AddParagraph();
                paragraph0.AppendText(item.MonAn.TenMonAn.ToString());
                paragraph0.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Left; // Căn trái
                cell0.CellFormat.VerticalAlignment = VerticalAlignment.Middle; // Căn giữa theo chiều dọc

                // Cột "SL"
                var cell1 = row.Cells[1];
                var paragraph1 = cell1.AddParagraph();
                paragraph1.AppendText(item.SoLuong.ToString());
                paragraph1.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Right; // Căn giữa
                cell1.CellFormat.VerticalAlignment = VerticalAlignment.Middle; // Căn giữa theo chiều dọc

                // Cột "ĐG"
                var cell2 = row.Cells[2];
                var paragraph2 = cell2.AddParagraph();
                paragraph2.AppendText(item.MonAn.DonGia?.ToString("N0"));
                paragraph2.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Right; // Căn phải
                cell2.CellFormat.VerticalAlignment = VerticalAlignment.Middle; // Căn giữa theo chiều dọc

                // Cột "Thành tiền"
                var cell3 = row.Cells[3];
                var paragraph3 = cell3.AddParagraph();
                paragraph3.AppendText(item.ThanhTien?.ToString("N0"));
                paragraph3.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Right; // Căn phải
                cell3.CellFormat.VerticalAlignment = VerticalAlignment.Middle; // Căn giữa theo chiều dọc
            }

            // Save document to file
            document.Save(fileBoNhiem, FormatType.Doc);

            // Close the document after save
            document.Close();

            
            this.PrinPriview(fileBoNhiem);

               #endregion =====  End Core=====
        }


    }
}
