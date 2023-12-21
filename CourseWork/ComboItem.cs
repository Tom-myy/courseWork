namespace CourseWork
{
    internal class ComboItem
    {
        public int Id { get; set; }
        public string Text { get; set; } = default!;

        public string FormattedText => $"{Id} {Text}";
    }
}
