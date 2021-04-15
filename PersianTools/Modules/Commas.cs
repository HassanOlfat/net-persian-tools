namespace PersianTools.Modules
{
    public static class Commas
    {
        public static string Add(uint number)
        {
            return number.ToString("#,##0");
        }

        public static string Add(int number)
        {
            return number.ToString("#,##0");
        }

        public static string Add(long number)
        {
            return number.ToString("#,##0");
        }

        public static string Add(ulong number)
        {
            return number.ToString("#,##0");
        }

        public static string Add(short number)
        {
            return number.ToString("#,##0");
        }

        public static string Add(ushort number)
        {
            return number.ToString("#,##0");
        }

         public static string Add(string number)
        {
            string NonCommas=number.Replace(",", "");
            long num;
            if (string.IsNullOrWhiteSpace(NonCommas))
            {
                throw new System.ArgumentException($"'{nameof(NonCommas)}' cannot be null or whitespace", nameof(NonCommas));
            }
            if (!long.TryParse(NonCommas,out num))
            {
                throw new System.ArgumentException($"'{nameof(NonCommas)}' cannot be Char", nameof(NonCommas));
            }
            return num.ToString("#,##0");
        }
        
        public static long Remove(string number)
        {
            string NonCommas=number.Replace(",", "");
            if (string.IsNullOrWhiteSpace(NonCommas))
            {
                throw new System.ArgumentException($"'{nameof(NonCommas)}' cannot be null or whitespace", nameof(NonCommas));
            }
            if (!long.TryParse(NonCommas,out _))
            {
                throw new System.ArgumentException($"'{nameof(NonCommas)}' cannot be Char", nameof(NonCommas));
            }
            return long.Parse(NonCommas);
        }
    }
}
