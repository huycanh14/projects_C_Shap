using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest.Questions
{
    class Question2
    {
        private List<string> _question = new List<string>();
        private void AddQuestion()
        {
            _question.Add("Viết một chương trình thực hiện các công việc sau:\n" +
                "1. Nhập vào một dãy số nguyên dương x1, x2, x3,...,xn (n > 0 && n <= 100)\n" +
                "2. In ra dãy số vừa nhập ra màn hình\n" +
                "3. Hoán vị phần tử có giá trị lớn nhất đầu tiên cho phần tử x1\n" +
                "vd dãy nhập vào: {5, 7, 9, 2, 6, 9 } thì dãy sau khi hoán vị là  {9, 7, 5, 2, 6, 9}");
            _question.Add("Viết một chương trình thực hiện các công việc sau:\n" +
                "1. Nhập vào 3 số thực a, b, c\n" +
                "2. Kiểm tra xem chúng có thành lập thành 3 cạnh của tam giác hay không? Nếu có hãy tính và in ra màn hình diện tích và chu vi của tam giác đó, ngược lại đưa ra thông báo không là cạnh của tam giác");
            _question.Add("Viết một chương trình thực hiện các công việc sau:\n" +
                "1. Nhập một mảng số nguyên N tối đa 1000 phần tử\n" +
                "2. In ra mảng vừa nhập" +
                "3. Sắp xếp mảng đó theo thứ tự giảm dần");
            _question.Add("Viết một chương trình thực hiện các công việc sau:\n" +
                "1. Nhập một mảng số nguyên N tối đa 1000 phần tử\n" +
                "2. In ra mảng vừa nhập" +
                "3. Đếm số lượng số nguyên tố nhỏ hơn 100 trong mảng");
            _question.Add("Viết một chương trình thực hiện các công việc sau:\n" +
                "1. Nhập một mảng số thực N tối đa 1000 phần tử\n" +
                "2. In ra mảng vừa nhập" +
                "3. In ra giá trị nhỏ nhất trong mảng số thực");
            _question.Add("Viết một chương trình thực hiện các công việc sau:\n" +
                "1. Nhập một mảng số nguyên N tối đa 1000 phần tử\n" +
                "2. In ra mảng vừa nhập" +
                "3. Tìm số hoàn thiện đầu tiên trong mảng");
            _question.Add("Viết một chương trình thực hiện các công việc sau:\n" +
                "1. Nhập một mảng số nguyên N tối đa 1000 phần tử\n" +
                "2. In ra mảng vừa nhập" +
                "3. Liệt kê các số hoàn thiện trong mảng");
            _question.Add("Viết một chương trình thực hiện các công việc sau:\n" +
                "1. Nhập một mảng số thực N tối đa 1000 phần tử\n" +
                "2. In ra mảng vừa nhập\n" +
                "3. Hãy tìm giá trị trong mảng mảng các số thực 'xa giá trị x nhất'");
            _question.Add("Hãy liệt kê các vị trí mà giá trị tại đó là số chính phương trong mảng một chiều các số nguyên");
            _question.Add("Hãy liệt hê các vị trí mà giá trị tại vị trí đó bằng giá trị dương nhỏ nhất trong mảng một chiều các số nguyên");
            _question.Add("Hãy liệt kê các giá trị trong mảng 1 chiều các số nguyên tố có chữ số đầu tiên là chữ số lẻ");
            _question.Add("Hãy liệt kê các giá trị toàn chữ só lẻ trong mảng một chiều các số nguyên");
            _question.Add("Cho mảng số thực có nhiều hơn ba giá trị và các giá trị trong mảng khác nhau từng đôi một. Hãy liệt kê tất cả các bộ ba giá trị(a, b, c) thỏa mãn điều kiện a = b + c với a, b, c là ba giá trị khác nhau trong mảng.\n" +
                "Ví dụ: (6, 2, 4)");
            _question.Add("Tính tổng các giá trị lớn hơn trị tuyệt đối các giá trị đứng liền sau nó trong mảng 1 ciều các số thực");
            _question.Add("Tính trung bình cộng các số nguyên tố tron mảng một chiều các số nguyên");
            _question.Add("Hãy sắp xếp các số nguyên tố trong mảng các số nguyên tăng dần các giá khác giữ nguyên giá trị và vị trí");
            _question.Add("hãy thêm một phần tử có giá trị x vào mảng tại vị trí k và in kết quả ra màn hình");
            _question.Add("Hãy thêm một giá trị x vào trong mảng tăng dần và giữ nguyên tính đơn diệu tăng của mảng");
            _question.Add("Hãy xóa tất cả các số 'chính phương' trong mảng một chiều các số nguyên");
            _question.Add("Hãy xóa tất cả các số lớn nhất trong mảng các số thực");
            _question.Add("Hãy xóa tất cả các số 'nguyên tố' trong mảng");
            _question.Add("Hãy đảo ngược thứ tự các số chẵn và số lẻ trong mảng mà vẫn giữ nguyên vị trí tương đối của chúng");
            _question.Add("Hãy đảo ngược mảng ban đầu");
            _question.Add("Hãy đếm số nguyên tố trong mang trận các số nguyên");
            _question.Add("Viết hàm tìm giá trị lớn nhất trong man trận số thực");
            _question.Add("Viết hàm kiểm tra trong ma trận các số nguyên có tồn tại giá trị chẵn nhỏ hơn 2004 hay không?");
            _question.Add("Tính tổng các giá trị nằm trên biên của ma trận");
            _question.Add("Đếm tần suất xuất hiện một giá trị x trong ma trận số thực");
            _question.Add("Đếm số lượng dương trên biên ma trận trong ma trận các số thực");
            _question.Add("Liệt kê chỉ số các dòng chứa toàn giá trị chẵn trong ma trận các số nguyên");
            _question.Add("Liệt kê các dòng có chứa giá trị âm trong ma trận các số thực");
            _question.Add("Liệt kê các dòng trong ma trận các số thực thỏa mãn đông thời các điều kiện sau:\n" +
                "Dòng có chứa giá trị âm, giá trị dương và giá trị 0 (phần tử trung hòa)");
            _question.Add("Tìm số hoàn thiện nhỏ nhất tron ma trận các số số nguyên");
            _question.Add("Viết hàm sắp xếp các phần tử trên một dòng tăn dần từ trái qua phải");
            _question.Add("Viết hàm sắp xếp các phần tử trên một dòng giảm dần tư trái sang phải");
            _question.Add("Viết hàm sắp xếp các phần tử trong ma trận theo yêu cầu sau\n" +
                "- Dòng có chỉ số chẵn tăng dần\n" +
                "- Dòng có chỉ số lẻ giảm dần");
        }

        public string GetQuestion()
        {
            AddQuestion();
            Random r = new Random();
            int number = r.Next(0, _question.Count);
            return _question[number];
        }
    }
}
