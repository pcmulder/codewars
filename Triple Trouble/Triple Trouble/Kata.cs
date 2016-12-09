public class Kata
{
    public static int TripleDouble(long num1, long num2)
    {
        return ContainsStraight(num1, 3) && ContainsStraight(num2, 2) ? 1 : 0;
    }

    private static bool ContainsStraight(long num, int length)
    {
        char[] chars = num.ToString().ToCharArray();

        int count = 1;
        char compareTo = chars[0];

        for (int i = 1; i < chars.Length; i++)
        {
            if (chars[i] == compareTo)
            {
                count++;

                if (count == length)
                {
                    return true;
                }
            }
            else
            {
                compareTo = chars[i];
                count = 1;
            }
        }

        return false;
    }
}
