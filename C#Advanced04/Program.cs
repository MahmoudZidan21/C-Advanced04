namespace C_Advanced04;
 using System.Collections;

internal class Program
{
    static void Main(string[] args)
    {
        #region non-generic hashtable : Hashtable

        // non-generic hashtable : Hashtable


        //Hashtable PhoneBook = new Hashtable();

        //PhoneBook.Add("Ahmed", "11111111");
        //PhoneBook.Add("Ali"  , "22222222");
        //PhoneBook.Add("Amr"  , "33333333");

        //      Console.WriteLine(PhoneBook.Count);

        //foreach (var item in PhoneBook)
        //{

        //    Console.WriteLine(item);
        //}


        //foreach (var item in PhoneBook.Keys)
        //{

        //    Console.WriteLine(item);
        //}

        //foreach (var item in PhoneBook)
        //{

        //    Console.WriteLine(item);
        //}
        // Console.WriteLine("=========================");

        //Console.WriteLine(PhoneBook["Ahmed"]);

        //PhoneBook.Contains("Ahmed");
        //PhoneBook.Clear();

        //PhoneBook.Remove(null); 
        #endregion
        #region generic hashtable : Hashtable

        //Dictionary<string, long > PhoneBook = new Dictionary<string, long>();

        //PhoneBook.Add("Ahmed", 11111111);
        //PhoneBook.Add("Ali"  , 22222222);
        //PhoneBook.Add("Amr"  , 33333333);




        //bool flag = PhoneBook.Remove("Ahmed", out long result);

        //Console.WriteLine(result);
        //Console.WriteLine(flag);



        //foreach (KeyValuePair<string , long> item in PhoneBook)
        //{
        //    Console.WriteLine(item);
        //} 
        #endregion

        #region HashSet
        //HashSet<string> Names = new HashSet<string>();

        // Names.Add("Ahmed");
        // Names.Add("Ali");
        // Names.Add("Amr");
        // Names.Add("Ahmed");

        // foreach (var item in Names)
        // {
        //     Console.WriteLine(item);
        // } 
        #endregion

        #region SortedDictionary
        //SortedDictionary<int , string> Pairs = new SortedDictionary int, string >();

        // Pairs.Add(23, "Ahmed");
        //  Pairs.Add( 13, "Omar");
        //   Pairs.Add( 20, "Amr");
        //   Pairs.Add( 1, "Amr");



        // foreach (KeyValuePair<int, string> item in Pairs)
        // {
        //     Console.WriteLine(item);
        // } 
        #endregion

        #region SortedList
        //SortedList<int, string> Pairs = new SortedList<int, string>();

        //  Pairs.Add(23, "Ahmed");
        //Pairs.Add(13, "Omar");
        //    Pairs.Add(20, "Amr"); 
        //Pairs.Add(20, "Amr");

        #endregion












    }
}
