namespace Clinic2018
{
    internal class SimpleDateFormat
    {
        private Locale locale;
        private string v;

        public SimpleDateFormat(string v, Locale locale)
        {
            this.v = v;
            this.locale = locale;
        }
    }
}