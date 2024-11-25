using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePad_Project
{
    public class OldPhonePadTests
    {
        public static void RunTests()
        {
            Console.WriteLine(OldPhonePadProcessor.OldPhonePad("33#") == "E" ? "Pass" : "Fail");
            Console.WriteLine(OldPhonePadProcessor.OldPhonePad("227*#") == "B" ? "Pass" : "Fail");
            Console.WriteLine(OldPhonePadProcessor.OldPhonePad("4433555 555666#") == "HELLO" ? "Pass" : "Fail");
            Console.WriteLine(OldPhonePadProcessor.OldPhonePad("8 88777444666*664#") == "TURING" ? "Pass" : "Fail");
            Console.WriteLine(OldPhonePadProcessor.OldPhonePad("222 2 22#") == "CAB" ? "Pass" : "Fail");
            Console.WriteLine(OldPhonePadProcessor.OldPhonePad("7 77 777 7777#") == "PQRS" ? "Pass" : "Fail");
            Console.WriteLine(OldPhonePadProcessor.OldPhonePad("0#") == " " ? "Pass" : "Fail");
            Console.WriteLine(OldPhonePadProcessor.OldPhonePad("111#") == "" ? "Pass" : "Fail");
        }
    }
}
