namespace BlasorManagement.Models
{
    public class CityRepository
    {
        private static List<String> cityes = [
            "Toronto",
            "Trani",
            "Bergamo",
            "Ancona",
            "Andria",
            "Bari"
            ];

        public static List<String> getCityes()
        {
            return cityes;
        }
    }
}
