using System.Text;

namespace OldPhonePad_Project
{
    public class OldPhonePadProcessor
    {
        private static readonly Dictionary<int, string> KeyPadMap = new Dictionary<int, string>
        {
            { 1, "" },
            { 2, "ABC" },
            { 3, "DEF" },
            { 4, "GHI" },
            { 5, "JKL" },
            { 6, "MNO" },
            { 7, "PQRS" },
            { 8, "TUV" },
            { 9, "WXYZ" },
            { 0, " " }
        };

        public static string OldPhonePad(string? input)
        {
            if (string.IsNullOrEmpty(input) || !input.EndsWith("#"))
                return "Input must be digit, non-empty and end with #";

            StringBuilder result = new StringBuilder();
            int lastKey = -1;
            int pressCount = 0;

            foreach (char key in input)
            {
                if (key == '#')
                {
                    AppendCharacter(result, lastKey, pressCount);
                    break;
                }
                else if (key == '*')
                {
                    if (result.Length > 0) 
                    {
                        AppendCharacter(result, lastKey, pressCount);
                        result.Remove(result.Length - 1, 1);
                    }
                        
                    lastKey = -1;
                    pressCount = 0;
                }
                else if (key == ' ')
                {
                    AppendCharacter(result, lastKey, pressCount);
                    lastKey = -1;
                    pressCount = 0;
                }
                else if (char.IsDigit(key))
                {
                    int currentKey = key - '0';
                    if (currentKey == lastKey)
                    {
                        pressCount++;
                    }
                    else
                    {
                        AppendCharacter(result, lastKey, pressCount);
                        lastKey = currentKey;
                        pressCount = 1;
                    }
                }
                else
                {
                    throw new ArgumentException($"Invalid character in input: {key}");
                }
            }

            return result.ToString();
        }

        private static void AppendCharacter(StringBuilder result, int key, int pressCount)
        {
            if (key == -1 || pressCount == 0)
                return;

            if (KeyPadMap.TryGetValue(key, out string letters) && letters.Length > 0)
            {
                int index = (pressCount - 1) % letters.Length;
                result.Append(letters[index]);
            }
        }
    }
}

