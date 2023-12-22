namespace CourseWork
{
    internal class ComboItem
    {
        public int Id { get; set; }
        public string Text { get; set; } = default!;

        // just override ToString method. It will do the same
        public string FormattedText => $"{Id} {Text}";
    }
}
