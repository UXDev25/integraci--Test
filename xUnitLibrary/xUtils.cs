namespace xUnitLibrary
{
    public class xUtils
    {
        public static int CalculateResult(int a, int b, int c)
        {

            if (a > 0)
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        return a + b + c;
                    }
                    else
                    {
                        return a + b;

                    }
                }
                else
                {
                    return a;

                }
            }
            else
            {
                return 0;

            }
        }

        public static string SendMsg(int result)
        {
            //Optimitzem la complexitat ciclomatica
            switch (result)
            {
                case 0:
                    return "El resultat és zero.";
                case < 0:
                    return "El resultat és negatiu.";
                default:
                    return "El resultat és positiu.";
            }
        }
    }
}
