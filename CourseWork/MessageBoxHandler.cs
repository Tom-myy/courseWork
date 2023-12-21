namespace CourseWork;

internal static class MessageBoxHandler
{
    public static void ValidationError(string message)
    {
        MessageBox.Show("Validation Error", message, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
