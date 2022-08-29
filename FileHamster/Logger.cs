namespace HamsterCopy;

public class Logger
{
    private RichTextBox textBox;

    public Logger(RichTextBox textBox)
    {
        this.textBox = textBox;
    }

    public void Write(string text)
    {
        textBox.Invoke(() =>
        {
            textBox.AppendText($"{DateTime.Now}: {text}\r\n");
        });
    }
}