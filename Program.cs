namespace clunk {
    public static class extension {
        public static bool IsEven(this int x) {
            if(x%2==0)
            {
                return true;
            }
            else{
                return false;
            }
        }
    }

    class Program {
        static void Main() {
            int number=10;
            Console.WriteLine(number.IsEven());
        }
    }
}