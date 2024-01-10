namespace DSA_RamuAjay_K.Arrays
{
    internal class ValidParenthesis
    {
        public bool IsValidParenthesis(string input)
        {
            var parenthesis = input.ToCharArray();
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dictionary = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            foreach (char c in parenthesis)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    char closedParenthesis = dictionary[c];
                    char openingParenthesis = stack.Pop();

                    if (closedParenthesis != openingParenthesis)
                        return false;
                }
            }
            return true;

        }
    }
}
