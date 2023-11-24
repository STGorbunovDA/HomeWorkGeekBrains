namespace MyClassLib.SettingsPage
{
    public class Settings
    {
        public string Setting1 = "";
        public string Setting2 = "";
        public string Setting3 = "";

        public override string ToString()
        {
            return $"Setting1={Setting1}, " +
                   $"Setting2={Setting2}, " +
                   $"Setting3={Setting3},";
        }
    }
}
