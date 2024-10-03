namespace BMICalculator.Models
{
    public class ListItem<TKey>
    {
        public TKey Value { get; set; }

        public string Description { get; set; }
    }
}
