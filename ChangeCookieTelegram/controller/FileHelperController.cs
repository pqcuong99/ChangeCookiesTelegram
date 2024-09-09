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
    }
}
