using NumberToWordsLib;

namespace NumberToText
{
    class Program
    {
        static void Main(string[] args)
        {
            var res1 = (3101010101010).NumberToText(Language.Persian);
            var res2 = (3000000).NumberToText(Language.English);
        }
    }
}
