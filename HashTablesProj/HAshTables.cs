using System;

namespace HashTablesProj;

internal class Program
{
    private static void Main(string[] args)
    {
        GetNextBytes(startIndex:0, "lore ")

            string input = string.Empty;

        while (!input.Equals("quit", StringComparison.OrdinalIgnoreCase))
        {
            Console.Write("> ");
            input = Console.ReadLine()

                //Console.WriteLine("Additive: {0}", AdditiveHash(input));
                Console.WriteLine("Folding: {0}", FoldingHAsh(input));
            //Console.WriteLine("DJB2: {0}", DJB2Hash(input));
        }
    }

    private static int AdditiveHash(string input)
    {
        int currentHashValue = 0;
        foreach (char c in input)
        {
            unchecked
            {
                currentHashValue += (int)c;
            }
        }
        return currentHashValue;
    }
    private static int FoldingHAsh(string input)
    {
        int hashValue = 0;

        int startIndex = 0;
        int currentFourBytes;
        do
        {
            currentFourBytes = GetNextBytes(startIndex, input);
            unchecked
            {
                hashValue += currentFourBytes;
            }
            startIndex += 4;
        } while (currentFourBytes != 0);

        return hashValue;
    }

    private static int GetNextBytes(int startIndex, string input)
    {
        throw new NotImplementedException();
    }
}
private static int GetNextBytes(int startIndex, string str)
    {
        int currentFourBytes = 0;

        currentFourBytes += GetNextBytes(str, startIndex);
        currentFourBytes += GetNextBytes(str, index: startIndex + 1) << 8;
        currentFourBytes += GetNextBytes(str, index: startIndex + 2) << 16;
        currentFourBytes += GetNextBytes(str, index: startIndex + 3) << 24;

        return currentFourBytes;
    }

    private static int GetNextBytes(string str, int startIndex)
    {
        throw new NotImplementedException();
    }

    private static int GetByte(string str, int index)
    {
        if (index < str.Length)
        {
            return (int)str[index];
        }
        return 0;
    }
}