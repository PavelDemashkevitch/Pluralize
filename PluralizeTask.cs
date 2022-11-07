namespace Pluralize
{
	public static class PluralizeTask
	{
        public static string PluralizeRubles(int count)
        {
            // Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
            var lastOneDigit = count % 10;
            var lastTwoDigits = count % 100;
            if ((lastTwoDigits > 20 || lastTwoDigits <= 10) && (lastOneDigit > 1 && lastOneDigit <= 4))
            {
                return "рубля";
            }
            else if ((lastTwoDigits > 20 || lastTwoDigits <= 10) && lastOneDigit == 1)
            {
                return "рубль";
            }
            else
            {
                return "рублей";
            }
        }
  	}
}