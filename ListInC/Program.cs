using System;
using System.Collections.Generic;

namespace ListInC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // khởi tạo 1 List các số nguyên rỗng
            List<int> MyList = new List<int>();

            // khởi tạo 1 List các số nguyên và chỉ định Capacity ban đầu là 5
            List<int> MyList2 = new List<int>(5);

            #endregion


            #region
            /*
            * Khởi tạo 1 List số nguyên có kích thước bằng với MyList2.
            * Sao chép toàn độ phần tử trong MyList2 vào MyList3.
            */
            List<int> MyList3 = new List<int>(MyList2);
            #endregion

            #region
            /*
            * Tạo 1 List các kiểu string và thêm 2 phần tử vào List.
            */
            List<string> MyList4 = new List<string>();
            MyList4.Add("Loc");
            MyList4.Add("Thanh");

            // In giá trị các phần tử trong List
            Console.WriteLine(" List ban dau: ");
            Console.WriteLine(" So luong phan tu trong List la: {0}", MyList4.Count);
            foreach (string item in MyList4)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            // Chèn 1 phần tử vào đầu List.
            MyList4.Insert(0, "Nguyen");

            // In lại giá trị các phần tử trong List để xem đã chèn được hay chưa
            Console.WriteLine(" List sau khi insert: ");
            Console.WriteLine(" So luong phan tu trong List la: {0}", MyList4.Count);
            foreach (string item in MyList4)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            // Kiểm tra 1 phần tử có tồn tại trong List hay không.
            bool isExists = MyList4.Contains("jhjhj");

            if (isExists == false)
            {
                Console.WriteLine(" Khong tim thay chuoi trong List");
            }

            #endregion
        }
    }
}
