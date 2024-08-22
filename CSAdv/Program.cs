using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAdv
{
    class Wanted<T>
    {
        public T Value;
        public Wanted(T value)
        {
            this.Value = value;
        }
    }

    class WantedTest<T, U>
            where T : IComparable
            where U : IComparable, IDisposable
    {

    }

    class SquareCalculator
    {
        public int this[int i]
        {
            get { return i * 2; }
            /*set { Console.WriteLine("{i}번째 상품 설정", i); }*/
        }
    }
    internal class Program
    {
        struct Point
        {
            public int x;
            public int y;
            public string testA;
            public string testB;

            // 구조체 -> 기본생성자 사용 x
            // 구조체 생성자 -> 변수가 모두 초기화 되어야 함!
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                testA = null;
                testB = "init";
            }
            public Point(int x, int y, string test)
            {
                this.x = x;
                this.y = y;
                testA = null;
                testB = test;
            }
        }
        static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }
        static void Main(string[] args)
        {
            Wanted<string> wantedString = new Wanted<string>("string");
            Wanted<int> wantedInt = new Wanted<int>(52273);
            Wanted<double> wantedDouble = new Wanted<double>(52.273);

            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedDouble.Value);

            SquareCalculator sc = new SquareCalculator();
            Console.WriteLine(sc[10]);
            Console.WriteLine(sc[11]);
            Console.WriteLine(sc[40]);
            /*sc[3] = 4;*/

            // out 키워드
            Console.WriteLine("숫자 입력 : ");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);
            if(result)
            {
                Console.WriteLine("입력한 숫자 : " +  output);
            } else
            {
                Console.WriteLine("숫자를 입력해주세요");
            }

            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;
            Console.WriteLine("현재 좌표 : (" + x + ", " + y + ")");
            NextPosition(x, y, vx, vy, out x, out y);
            Console.WriteLine("현재 좌표 : (" + x + ", " + y + ")");
        }
    }
}
