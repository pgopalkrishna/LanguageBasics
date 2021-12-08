using System;
namespace LanguageBasics.Assignment2
{
    class StringMethods
    {
        //Uncomment Main() method to execute
        //static void Main(string[] args)
        //{
        //    dynamic result;
        //    string str = "Hello world";
        //    Console.WriteLine("str=>{0}", str);
        //    Console.WriteLine("***************************");
        //    //1)Clone
        //    Object clonedStr;
        //    clonedStr = str.Clone();
        //    Console.WriteLine("Cloned string from str=>{0}", clonedStr);
        //    Console.WriteLine("***************************");

        //    //2)Compare
        //    result = string.Compare(str, clonedStr.ToString());
        //    Console.WriteLine("comapre result of {0} and {1}=> {2}", str, clonedStr.ToString(), getStringsLexicalRelationBySortOrder(result));
        //    result = string.Compare("Brad", "Amy");
        //    Console.WriteLine("comapre result of {0} and {1}=> {2}", "Brad", "Amy", getStringsLexicalRelationBySortOrder(result));
        //    result = string.Compare("Amy", "Kathrin");
        //    Console.WriteLine("comapre result of {0} and {1}=> {2}", "Amy", "Kathrin", getStringsLexicalRelationBySortOrder(result));
        //    Console.WriteLine("***************************");

        //    //3)CompareOrdinal
        //    result = string.CompareOrdinal("hello", "hello");
        //    Console.WriteLine("CompareOrdinal result of {0} and {1}=> {2}", "hello", "hello", getStringsLexicalRelationByNumericValues(result));
        //    result = string.CompareOrdinal("hello", "csharp");
        //    Console.WriteLine("CompareOrdinal result of {0} and {1}=> {2}", "hello", "csharp", getStringsLexicalRelationByNumericValues(result));
        //    result = string.CompareOrdinal("hello", "mello");
        //    Console.WriteLine("CompareOrdinal result of {0} and {1}=> {2}", "hello", "mello", getStringsLexicalRelationByNumericValues(result));
        //    Console.WriteLine("***************************");
        //    //4)CompareTo
        //    result = str.CompareTo(clonedStr);
        //    result = (result == 0) ? "strings matched" : "strings not matched";
        //    Console.WriteLine("string str & clonedStr=>{0}", result);
        //    result = str.CompareTo("Hello Universe");
        //    result = (result == 0) ? "strings matched" : "strings not matched";
        //    Console.WriteLine("string str & 'Hello Universe'=>{0}", result);
        //    Console.WriteLine("***************************");

        //    //5)Concat
        //    Console.WriteLine("Concated string=>{0}", string.Concat(str, "Hello Universe"));
        //    Console.WriteLine("***************************");

        //    //6)Contains
        //    result = str.Contains("world");
        //    Console.WriteLine("str {0} 'world'", result ? "contains" : "doesn't contains");
        //    Console.WriteLine("***************************");

        //    //7)Copy
        //    string newStr = string.Copy("string.Copy(str) creates new instance of string with value specified as argument");
        //    Console.WriteLine(newStr);
        //    Console.WriteLine("***************************");
        //    //8)CopyTo
        //    char[] ch = new char[5];
        //    str.CopyTo(6, ch, 0, 5);//Parameters:sourceindex,char array,destination index, numberof chars to copy
        //    Console.WriteLine("str.CopyTo()=>");
        //    Console.WriteLine(ch);
        //    Console.WriteLine("***************************");
        //    //9)EndsWith
        //    Console.WriteLine("does '{0}' string ends with 'world'? =>{1}", str, str.EndsWith("world") ? "Yes" : "No");
        //    Console.WriteLine("does '{0}' string ends with 'Universe'? =>{1}", str, str.EndsWith("Universe") ? "Yes" : "No");
        //    Console.WriteLine("***************************");
        //    //10)Equals
        //    Console.WriteLine(" strings '{0}' and '{1}' are {2}",str,clonedStr,str.Equals(clonedStr.ToString())?"equal":"not equal");
        //    Console.WriteLine("***************************");

        //    //11)Format
        //    Console.WriteLine(string.Format("{0:D}", DateTime.Now));
        //    Console.WriteLine("***************************");
        //    //12)GetEnumerator
        //    CharEnumerator che = str.GetEnumerator();
        //    while (che.MoveNext())
        //    {
        //        Console.WriteLine(che.Current);
        //    }
        //    Console.WriteLine("***************************");

        //    //13)GetHashCode
        //    Console.WriteLine("GetHashCode: " + str.GetHashCode());
        //    Console.WriteLine("***************************");

        //    //14)GetType
        //    Console.WriteLine("GetType: " + str.GetType());
        //    Console.WriteLine("***************************");

        //    //15)GetTypeCode
        //    Console.WriteLine("GetTypeCode: "+str.GetTypeCode());
        //    Console.WriteLine("***************************");

        //    //16)IndexOf
        //    Console.WriteLine("Index of :"+ str.IndexOf("world"));
        //    Console.WriteLine("***************************");

        //    //17)Insert
        //    Console.WriteLine("Insert 'from'to {0}=>{1}",str, str.Insert(5," from"));
        //    Console.WriteLine("***************************");

        //    //18)Intern
        //    Console.WriteLine("Intern:"+string.Intern(str));
        //    Console.WriteLine("***************************");

        //    //19)IsInterned
        //    Console.WriteLine("IsInterned:" + string.IsInterned(str));
        //    Console.WriteLine("IsInterned:" + string.IsInterned("India"));
        //    Console.WriteLine("***************************");

        //    //20)IsNormalized
        //    Console.WriteLine("IsNormalized:" + str.IsNormalized());
        //    Console.WriteLine("***************************");

        //    //21)IsNullOrEmpty
        //    Console.WriteLine("IsNullOrEmpty:" + string.IsNullOrEmpty(str));
        //    Console.WriteLine("IsNullOrEmpty:" + string.IsNullOrEmpty(""));
        //    Console.WriteLine("***************************");

        //    //22)IsNullOrWhiteSpace
        //    Console.WriteLine("IsNullOrEmpty:" + string.IsNullOrWhiteSpace(str));
        //    Console.WriteLine("IsNullOrEmpty:" + string.IsNullOrWhiteSpace(" "));
        //    Console.WriteLine("***************************");

        //    //23)Join
        //    string[] strArr = { "rock", "paper", "scissors" };
        //    Console.WriteLine("join string array '{0}'with '-'=> {1}",strArr,string.Join("-",strArr));
        //    Console.WriteLine("***************************");

        //    //24)LastIndexOf
        //    Console.WriteLine("Index of last occurance of 'l'in {0} is : {1}", str, str.LastIndexOf('l'));
        //    Console.WriteLine("***************************");

        //    //25)LastIndexOfAny
        //    Console.WriteLine("Index of last occurance of 'l' & 'o' in {0} is : {1}", str, str.LastIndexOfAny("'l','o' ".ToCharArray()));//returns last occurance of multiple chars
        //    Console.WriteLine("***************************");

        //    //26)Normalize
        //    Console.WriteLine("Normalize :"+str.Normalize());//returns a new string whose textual value is same as this string, but whose binary representation is in Unicode normalization form
        //    Console.WriteLine("***************************");

        //    //27)PadLeft
        //    Console.WriteLine("setting padding to left by 2 whitespaces on '{0}'=>'{1}'", str, str.PadLeft(str.Length + 2));
        //    Console.WriteLine("setting padding to left by 2 '*'padding chars on '{0}'=>'{1}'", str, str.PadLeft(str.Length + 2, '*'));
        //    Console.WriteLine("***************************");

        //    //28)PadRight
        //    Console.WriteLine("setting padding to left by 2 whitespaces on '{0}'=>'{1}'", str, str.PadRight(str.Length + 2));
        //    Console.WriteLine("setting padding to left by 2 '*'padding chars on '{0}'=>'{1}'", str, str.PadRight(str.Length + 2, '*'));
        //    Console.WriteLine("***************************");

        //    //29)Remove
        //    Console.WriteLine("Removing 'world from '{0}'=>'{1}'", str, str.Remove(6));//returns new string excluiding substring which starts with given startindex to endindex
        //    Console.WriteLine("***************************");


        //    //30)Replace
        //    Console.WriteLine("Replacing 'world' with 'Universe'in '{0}'=>'{1}'", str, str.Replace("world", "Universe"));
        //    Console.WriteLine("***************************");

        //    //31)Split - split string using comma saparated value as well as using multiple character to split string as (comma, whitespace, @ sign) 
        //    string str1 = "rock,paper,scissors";
        //    result = str1.Split(',');
        //    Console.WriteLine("splitting '{0}' string as follows:", str1);
        //    foreach (string r in result) {
        //        Console.WriteLine(r);
        //    }
        //    Console.WriteLine("------------------------------");
        //    str1 = "my email ids are personal@exampe.com,professional@example.com";
        //    char[] seperator = { ',', ' ', '@' };
        //    result = str1.Split(seperator);
        //    Console.WriteLine("splitting '{0}' string as follows:", str1);
        //    foreach (string r in result)
        //    {
        //        Console.WriteLine(r);
        //    }
        //    Console.WriteLine("***************************");

        //    //32)StartsWith
        //    Console.WriteLine("does '{0}' string starts with 'world'? =>{1}", str, str.StartsWith("Hello") ? "Yes" : "No");
        //    Console.WriteLine("does '{0}' string starts with 'Universe'? =>{1}", str, str.StartsWith("world") ? "Yes" : "No");
        //    Console.WriteLine("***************************");

        //    //33)Substring
        //    Console.WriteLine("Substring of '{0}'=>{1}", str, str.Substring(0, 5));
        //    Console.WriteLine("Substring of '{0}'=>{1}", str, str.Substring(0, 4));
        //    Console.WriteLine("Substring of '{0}'=>{1}", str, str.Substring(6));
        //    Console.WriteLine("***************************");

        //    //34)ToCharArray
        //    Console.WriteLine("string to char array=>");
        //    result = "INDIA".ToCharArray();
        //    foreach (char r in result)
        //    {
        //        Console.WriteLine(r);
        //    }
        //    Console.WriteLine("***************************");

        //    //35)ToLower
        //    Console.WriteLine("converting string to lowercase:{0}", "INDIA".ToLower());
        //    Console.WriteLine("***************************");

        //    //36)ToLowerInvariant
        //    Console.WriteLine("converting string to ToLowerInvariant:{0}", str.ToLowerInvariant());
        //    Console.WriteLine("***************************");

        //    //37)ToString
        //    Console.WriteLine("Converting Object of string value:{0} to string: '{1}'", newStr, newStr.ToString());
        //    Console.WriteLine("***************************");

        //    //38)ToUpper
        //    Console.WriteLine("converting string to uppercase:{0}", "india".ToLower());
        //    Console.WriteLine("***************************");

        //    //39)Trim
        //    Console.WriteLine("trimmingstring '{0}'=>'{1}'", " INDIA ", " INDIA ".Trim());
        //    char[] charsToTrim ={'j','o','y'};
        //    Console.WriteLine("trimmingstring '{0}'=>'{1}'", "joyandjoy", "joyandjoy".Trim(charsToTrim));
        //    Console.WriteLine("trimmingstring '{0}'=>'{1}'", " INDIA1111 ", " INDIA1111".Trim('1'));
        //    Console.WriteLine("***************************");

        //    //40)TrimEnd
        //    Console.WriteLine("TrimEnd:{0}","Hello world".TrimEnd('d'));
        //    Console.WriteLine("***************************");

        //    //41)TrimStart
        //    Console.WriteLine("TrimStart:{0}", "Hello world   ".TrimStart('H'));
        //    Console.WriteLine("***************************");
        //}
        public static string getStringsLexicalRelationBySortOrder(int r) {
            var relation = "";
            switch (r)
            {
                case 0:
                    relation = "firstStr==secondStr,firstStr occurs in the same position as  secondStr in sort Order";
                    break;
                case 1:
                    relation = "firstStr > secondStr,firstStr follows secondStr in sort Order";
                    break;
                case -1:
                    relation = "firstStr < secondStr ,firstStr preceds secondStr in sort Order";
                    break;
            }
            return relation;
        }
        public static string getStringsLexicalRelationByNumericValues(int r)
        {
            var relation = "";
            if(r!=0)
            r = r > 0 ? 1 : -1;
            switch (r)
            {
                case 0:
                    relation = "firstString==secondString,firstString is equal as secondString ";
                    break;
                case 1:
                    relation = "firstString > secondString,firstString is greater than secondString";
                    break;
                case -1:
                    relation = "firstString < secondString ,firstString is less than secondString";
                    break;
            }
            return relation;
        }
    }
}
