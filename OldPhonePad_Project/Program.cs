using OldPhonePad_Project;

Console.WriteLine(OldPhonePadProcessor.OldPhonePad("33#"));
Console.WriteLine(OldPhonePadProcessor.OldPhonePad("227*#"));
Console.WriteLine(OldPhonePadProcessor.OldPhonePad("4433555 555666#"));
Console.WriteLine(OldPhonePadProcessor.OldPhonePad("8 88777444666*664#"));
Console.WriteLine(OldPhonePadProcessor.OldPhonePad("9999*9999233 33688*883 3444662*#"));
Console.WriteLine(OldPhonePadProcessor.OldPhonePad("9999*9999233 33688*883 3444662*"));
Console.WriteLine(OldPhonePadProcessor.OldPhonePad(""));
Console.WriteLine(OldPhonePadProcessor.OldPhonePad(null));
Console.WriteLine(OldPhonePadProcessor.OldPhonePad("ABCD"));

//Test cases
Console.WriteLine("-------------------------------------------------------------------");
Console.WriteLine("Test Cases");
Console.WriteLine("-------------------------------------------------------------------");
OldPhonePadTests.RunTests();
