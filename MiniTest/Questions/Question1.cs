using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest.Questions
{
    class Question1
    {
        private List<string> _question = new List<string>();
        private void AddQuestion()
        {
            _question.Add("In ra dòng chữ 'Hello world from C'\n" +
                "In ra màn hình lần lượt các kết quả sau, mỗi kết quả 1 dòng:\n" +
                "1. Tích của 2 số 2018, 2019\n" +
                "2. Thương của phép chia 2020 cho 512 (không lấy phần lẻ)\n" +
                "3. Số dư của phép chia 2020 cho 512\n");

            _question.Add("In ra màn hình lần lượt các kết quả sau, mỗi kết quả trên một dòng:\n" +
                "1. Tích của 2 số 17 và 342\n" +
                "2. Hiệu của 2 số 20342 và 5412\n" +
                "3. Thương của 1024 cho 111" +
                "4. Trung bình cộng của 2 số 315 và 352");
            _question.Add("In ra màn hinh lần lượt các kết quả sau, mỗi kết quả trên một dòng:\n" +
                "1. S, biết S = (a+b) * (a-b) với a = 15 và b = 12\n" +
                "2. Góa trị của phép tính: 12 * 12 * 12 *....*12 (có 8 số 12)+" +
                "3. Trung bình cộng của 3 số 123, 135 và 3252");
            _question.Add("In ra màn hình lần lượt các kết quả sau, mỗi kết quả 1 dòng\n" +
                "1. Tổng 1 + 2 + 3 + ... + 2018\n" +
                "2. Tổng 2 + 4 + 6 + ... + 2020");
            _question.Add("Tạo một biến PI có giá trị là 3.14159, và biến r có giá trị là 1233. In ra diện tích của hình tròn bán kính r");
            _question.Add("Gia đình Uligo tháng vừa rồi dùng hết 189 số điện.\n" +
                "Biết 100 số điện đầu, mỗi số giá trị 2500 đồng, từ số điện thứ 101 trở lên, giá sẽ là 3500 đồng mỗi số\n" +
                "Hỏi gia đình Uligo phải trả bao nhiêu tiền điện cho tháng vừa rồi.\n" +
                "Yêu cầu: Dùng một biến lưu số điện và 2 biến lưu hai mức giá");
            _question.Add("Tính điểm trung bình của cả lớp, biết rằng trong lớp có:\n" +
                "5 học sinh đạt điểm 10\n" +
                "6 học sinh đạt điểm 9\n" +
                "7 học sinh đạt điểm 8\n" +
                "8 học sinh đạt điểm 7");
            _question.Add("Ba vòi nước cùng chảy vào bể, mỗi vòi chảy một mình thì sau lần lượt 4, 5 và 6h sẽ đầy bể. Hỏi ba vòi cùng chảy thì bao lâu đầy bể");
            _question.Add("Tính tích của các cặp số sau và in ra màn hình theo mẫu:\n" +
                "'Product of A and B is C'\n" +
                "Mỗi tích ra in trên một dòng\n" +
                "# 7 và 8\n" +
                "# 17 và 18\n" +
                "# 2017 và 2018");
            _question.Add("Cho a @ b  = 3 * a - b : 2\n" +
                "In ra các giá trị sau (mỗi giá trị trên một dòng)\n" +
                "# 4 @ 6\n" +
                "# 6 @ 4\n" +
                "# 12 # (8 @ 4)");
            _question.Add("Cho a @ b = Tổng của thương và số dư khi a chia cho b\n" +
                "In ra các giá trị sau (mỗi giá tị trên một dòng):\n" +
                "# 2018 @ 16\n" +
                "# 288 @ 3 @ 8");
            _question.Add("Cho a @ b = 2018 : a - b * a\n" +
                "In ra các giá trị sau (mỗi giá trị trên một dòng)\n" +
                "# 2018 @ 16\n" +
                "# 288 @ 3 @ 8\n" +
                "# 2 @ 3 @ 4 @ 5");
            _question.Add("Viết chương trình nhập tên một người và in ra câu chào theo mâu:\n" +
                "Hello {tên nhập vào}, how do you do");
            _question.Add("Viết chương trình nhập vào 3 số tự nhiên (mỗi số trên một dòng), in ra tổng của 3 số đó");
            _question.Add("Viết chương trình nhập vào chiều cao và độ dài cạnh đáy của tam giác (mỗi số trên một dòng). In ra màn hình diện tích của tam giác đó");
            _question.Add("Cho N học sinh, chia nhau K quả táo cho mỗi học sinh đều được số táo bằng nhau, và số táo mỗi người nhận được là lớn nhất có thể. Số táo còn lại (không chia được nữa) được trả lại vào rổ. Hỏi mỗi bạn được bao nhiêu quả táo, và trong rổ còn lại bao nhiêu quả táo\n" +
                "Viết chương trình nhập vào 2 số N và K. In ra màn hình đáp số cho các câu hỏi ở trên, mối số trên một dòng\n" +
                "Vì dụ: Dữ liệu đầu vào: 6  50 ==> Dữ liệu đầu ra: 8  2");
            _question.Add("Viết chương trình nhập vào một số tự nhiên, in ra số tự nhiên liền trước và liến sau của nó ra màn hình theo ví dụ bên dưới\n" +
                "Ví dụ dữ liệu đầu vào: 179\n" +
                "Ví dụ kết quả ra:\n" +
                "The next number for the number 179 is 180\n" +
                "THe previos number for the number 179 is 178");
            _question.Add("Viết chương trình nhập vào một số tự nhiên, in ra chữ số tận cùng của nó và cho biết đó là số chẵn hay lẻ");
            _question.Add("Nhập vào chữ số tự nhiên N và in ra chữ số hàng chục của nó. Cho biết đó là số chẵn hay lẻ");
            _question.Add("Nhập vào chữ số tự nhiên N và viết ngược lại số đó. VD: 12345 => 54321");
            _question.Add("Nhập vào số tự nhiên V < 10000. In ra tổng các chữ số của nó. VD: 179 => 17");
            _question.Add("Nhập vào chữ số  thực a. In ra màn hình phần thập phân của nó, làm tròn đên 3 chữ số thập phân");
            _question.Add("Nhập vào một số thực dương a. In ra màn hình chữ số đàu tiên của phần thập phân đó:\n" +
                "Ví dụ: 1.79 ==> 7");
            _question.Add("Nhập vào một số tự nhiên N. In ra màn hình năm N thuộc thế kỷ thứ mấy. Lưu ý rắng thế kỷ 20 bắt đầu từ năm 1901\n" +
                "VD: 2000 => 20");
            _question.Add("Nhập vào 2 số nguyên, in ra màn hinh:\n" +
                "+ Tổng của 2 số đó, nếu cả 2 số đều dương\n" +
                "+ Tích của 2 số đps nếu vả 2 số đều âm\n" +
                "+ Nếu không in ra màn hình số lớn hơn trong 2 số đó");
            _question.Add("Nhập vào số thực R, in ra màn hình chu vi và diện tích của hình trong bán bính R,m làm trong đến 3 chữ số sau dấu phẩy");
            _question.Add("Nhập vào một số tự nhiên N > 10000, in ra màn hình số lượng chữ số của số đó theo mẫu bên dưới\n" +
                "VD: input: 123 => output: It's a 3-digit number");
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
