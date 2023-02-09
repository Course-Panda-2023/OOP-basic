using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Bank.Utils
{
    public class Operation
    {
        public char[] operationKeys = { 'D', 'W', 'C' };
        public string[] operationFullTextKeys = { "deposit", "withdraw", "close existing account" };
        public Dictionary<char, string> operationText = new Dictionary<char, string>();
        
        public Dictionary<string, Func<object, int>> operations = new Dictionary<string, Func<object, int>>();

        public Operation()
        {
            Span<char> operation = operationKeys.AsSpan();
            Span<string> operationFullTextKey = operationFullTextKeys.AsSpan();
            
            for (int i = 0; i < operation.Length; ++i)
            {
                operationText.Add(operation[i], operationFullTextKey[i]);
            }
        }
    }
}
