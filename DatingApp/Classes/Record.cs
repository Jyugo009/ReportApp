namespace DatingApp.Classes
{
    public class Record
    {
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(MyDoubleConverter))]
        public double Bonuses { get; }
        public string Id { get;}
        public string Lady { get; }


        public Record(double bonuses, string id, string lady)
        {
            Bonuses = bonuses;
            Id = id;
            Lady = lady;
        }


    }
}
