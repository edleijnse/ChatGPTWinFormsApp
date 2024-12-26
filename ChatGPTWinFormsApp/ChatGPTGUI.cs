namespace ChatGPTWinFormsApp;

public partial class ChatGPTGUI : Form
{
    private static List<string> _contentHistory; // Shared global variable
    public ChatGPTGUI()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // throw new System.NotImplementedException();
        _contentHistory = new List<string>();
    }

    private void label1_Click(object sender, EventArgs e)
    {
        // throw new System.NotImplementedException();
    }

    private void textQuestion_TextChanged(object sender, EventArgs e)
    {
       // throw new System.NotImplementedException();
    }

    private void buttonAsk_Click(object sender, EventArgs e)
    {
        // throw new System.NotImplementedException();
        Cursor = Cursors.WaitCursor;
        FillAnswer();
        Cursor = Cursors.Default;
        
    }
    private void FillAnswer()
    {
        try
        {
            textAnswer.Text = string.Empty;
            var aiClient = new OpenAIClient();
            string apiKey = aiClient.ReadApiKey();

            string inputText = textQuestion.Text;
            string myModel = "";

            // Example model assignment and interface updates
            myModel = "gpt-4o";

            // Use the shared _contentHistory here
            // var getOpenAIResponseGpt4Task = aiClient.GetOpenAIResponseGpt4(myModel, inputText, contentHistory, apiKey);
            // getOpenAIResponseGpt4Task.Wait();
            string myAnswer = aiClient.GetOpenAIResponseGpt4(myModel, inputText, _contentHistory, apiKey);
            string myAnswerFormatted = myAnswer.Replace("\n\n", Environment.NewLine + Environment.NewLine);
            // Add myAnswer to _contentHistory
            _contentHistory.Add(myAnswerFormatted);
            textAnswer.Text = myAnswerFormatted;

            if (textHistory.Text.Length == 0)
            {
                textHistory.Text = textHistory.Text +
                                   inputText + Environment.NewLine + myAnswerFormatted;
            }
            else
            {
                textHistory.Text = textHistory.Text + Environment.NewLine + Environment.NewLine +
                                   inputText + Environment.NewLine + myAnswerFormatted;
            }
        }
        catch (IOException ex)
        {
            // Handle exceptions
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    private void textHistory_TextChanged(object sender, EventArgs e)
    {
        // throw new System.NotImplementedException();
    }

    private void buttonNextQuestion_Click(object sender, EventArgs e)
    {
        textQuestion.Text = "";
    }

    private void buttonCopyAnswer_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(textAnswer.Text))
        {
            Clipboard.SetText(textAnswer.Text);
            MessageBox.Show("Answer copied to clipboard, use CTRL+V to paste it");
        }
    }

    private void buttonCopyChat_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(textHistory.Text))
        {
            Clipboard.SetText(textHistory.Text);
            MessageBox.Show("Complete chat copied to clipboard, use CTRL+V to paste it");
        }
    }

    private void buttonNewChat_Click(object sender, EventArgs e)
    {
        textQuestion.Text = string.Empty;
        _contentHistory.Clear();
        if (!string.IsNullOrEmpty(textHistory.Text))
        {
            textHistory.Text = string.Empty;
            textAnswer.Text = string.Empty;
        }
    }
}