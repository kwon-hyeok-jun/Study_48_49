//using System;
//using System.Collections.Specialized;

//namespace ListDictionaryDemo
//{
//    //[0] 데모용 Book 클래스
//    class Book
//    {
//        public string Title { get; set; }
//        public string Author { get; set; }
//        public string ISBN { get; set; }
//    }

//    class ListDictionaryDemo
//    {
//        static void Main()
//        {
//            //[1] 개체의 인스턴스 생성 -> 속성값 초기화
//            Book b1 = new Book();
//            b1.Title = "ASP.NET"; b1.Author = "박용준"; b1.ISBN = "1234";

//            //[2] Object Intializer(개체 초기화자)
//            Book b2 = new Book() { Title = "C#", Author = "박용준", ISBN = "4321" };

//            //[3] ListDictionary 클래스에 개체 담기 : Key, Value 쌍으로 개체 값 저장
//            ListDictionary ld = new ListDictionary();
//            ld.Add("첫번째", b1);
//            ld.Add("두번째", b2);

//            //[4] object 형식으로 저장된 값을 Book으로 변환 후 출력
//            Console.WriteLine(((Book)ld["첫번째"]).Title);

//            Book b = (Book)ld["두번째"];
//            Console.WriteLine("{0}, {1}, {2}", b.Title, b.Author, b.ISBN);
//        }
//    }
//}

//public interface IKs { }
//public class GoodCar { }
//public class BadCar { public BadCar(string message) { } }
//public class OfficeCamper : GoodCar, IKs { }
//public class CarValue<T> where T : struct { } // 값 형식만
//public class CarReference<T> where T : class { } // 참조 형식만
//public class CarNew<T> where T : new() { } // Default 생성자
//public class CarClass<T> where T : GoodCar { } // GoodCar에서 파생
//public class CarInterface<T> where T : IKs { } // IKs인터페이스

//public class TypeConstraint
//{
//    public static void Main()
//    {
//        CarValue<int> c = new CarValue<int>(); // struct 성공
//        CarReference<string> cs = new CarReference<string>(); // class 성공   
//        CarNew<GoodCar> cn = new CarNew<GoodCar>(); // new() 성공
//        CarClass<OfficeCamper> cc = new CarClass<OfficeCamper>(); // 사용자 정의 타입
//        CarInterface<IKs> h = new CarInterface<IKs>(); // 인터페이스 지정
//    }
//}


//using System;

//namespace GenericsDemo
//{
//    //[1] 형식 매개 변수 2개 사용 
//    class Pair<T, V>
//    {
//        public T First { get; set; }
//        public V Second { get; set; }

//        public Pair(T first, V second)
//        {
//            First = first;
//            Second = second;
//        }
//    }

//    class GenericsDemo
//    {
//        static void Main()
//        {
//            //[A] string, bool 2개 형식 받기
//            var my = new Pair<string, bool>("나는 멋져!", true);
//            Console.WriteLine($"{my.First}: {my.Second}");

//            //[B] int, double 2개 형식 받기
//            var tuple = new Pair<int, double>(1234, 3.14);
//            Console.WriteLine($"{tuple.First}, {tuple.Second}");
//        }
//    }
//}


//using System;

//namespace DotNet
//{
//    //[1] 제네릭 클래스 설계
//    public class Hello<T>
//    {
//        private T _message; //[A] 필드
//        public Hello() { _message = default(T); } //[B] 기본 생성자
//        public Hello(T message) { this._message = message; } //[C] 매개 변수가 있는 생성자
//        public void Say(T message) =>
//            Console.WriteLine("{0}", message); //[D] 제네릭 메서드
//        public T GetMessage() => this._message; //[E] 일반 메서드
//    }

//    class GenericMethod
//    {
//        static void Main()
//        {
//            //[2] 제네릭 클래스 호출
//            Hello<int> hi = new Hello<int>();
//            hi.Say(1234);
//            Hello<string> hs = new Hello<string>();
//            hs.Say("안녕");
//        }
//    }
//}


//using System;

//static class ExtensionFunction
//{
//    // static 클래스안에 static 메서드의 첫번째 매개 변수에 this가 붙은 것은 확장 메서드
//    static string Three(this string value)
//    {
//        // 특정 문자열 뒤에 이 메서드가 호출되면 문자열 중 3개만 반환 
//        return value.Substring(0, 3);
//    }

//    static void Main()
//    {
//        Console.WriteLine("안녕하세요.".Three());
//    }
//}


