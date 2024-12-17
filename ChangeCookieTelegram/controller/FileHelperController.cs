using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCookieTelegram.controller
{
    public class FileHelperController
    {
        public static string SelectTextFile()
        {
            // Tạo một đối tượng OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thuộc tính của OpenFileDialog
            openFileDialog.Filter = "Text Files (*.txt)|*.txt"; // Chỉ hiển thị các tệp .txt
            openFileDialog.Title = "Select a Text File"; // Tiêu đề của hộp thoại

            // Hiển thị hộp thoại và kiểm tra xem người dùng đã chọn tệp hay không
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Trả về đường dẫn của tệp đã chọn
                return openFileDialog.FileName;
            }

            // Nếu không có tệp nào được chọn, trả về null
            return null;
        }
        public static string[] ReadAllLines(string filePath)
        {
            try
            {
                // Đọc tất cả các dòng từ tệp và trả về mảng chuỗi
                return File.ReadAllLines(filePath);
            }
            catch (Exception e)
            {
                return Array.Empty<string>(); // Trả về mảng rỗng nếu có lỗi
            }
        }
        public static void ClearTextInFile(string filePath)
        {
            try
            {
                // Xóa nội dung của file
                File.WriteAllText(filePath, string.Empty);
            }
            catch (Exception ex)
            {
            }
        }
        public static void TextInFile(string filePath, string text)
        {
            try
            {
                // Xóa nội dung của file
                File.WriteAllText(filePath, string.Empty);
                File.WriteAllText(filePath, text);
            }
            catch (Exception ex)
            {
            }
        }
        
        public static void WriteToFile(string filePath, string content)
        {
            try
            {
                // Kiểm tra xem file đã tồn tại chưa
                if (File.Exists(filePath))
                {
                    // Nếu file tồn tại, xóa nội dung cũ
                    File.WriteAllText(filePath, content);
                }
                else
                {
                    // Nếu file chưa tồn tại, tạo mới file và ghi nội dung
                    File.WriteAllText(filePath, content);
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void DeleteDlbFilesInSubFolders(string inputFolder)
        {
            try
            {
                // Kiểm tra xem thư mục đầu vào có tồn tại không
                if (!Directory.Exists(inputFolder))
                {
                    return;
                }

                // Lấy tất cả các thư mục con trong thư mục đầu vào
                string[] subFolders = Directory.GetDirectories(inputFolder);

                // Duyệt qua tất cả các thư mục con
                foreach (var folder in subFolders)
                {
                    // Lấy tất cả các file có đuôi .dlb trong thư mục con
                    string[] dlbFiles = Directory.GetFiles(folder, "*.dlb");

                    // Duyệt qua từng file .dlb và xóa
                    foreach (var file in dlbFiles)
                    {
                        try
                        {
                            // Xóa file .dlb
                            File.Delete(file);
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
