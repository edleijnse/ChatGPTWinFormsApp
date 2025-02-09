using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Web;
using OpenAI;
using OpenAI.Chat;

namespace ChatGPTWinFormsApp
{
    public class OpenAIClient
    {
        public static string EscapeHtml(string input)
        {
            // Escape standard HTML characters
            string escaped = HttpUtility.HtmlEncode(input);

            // Optionally replace special characters if needed
            escaped = escaped.Replace("Ü", "Ü").Replace("ü", "ü");

            return escaped;
        }

        public string ReadApiKey()
        {
            // Get the current working directory
            // string currentDir = Directory.GetCurrentDirectory();
            
            // Get the directory one level above the current working directory
            // string parentDir = Directory.GetParent(currentDir)?.FullName;
            string parentDir = "C:\\";

            if (parentDir == null)
            {
                throw new DirectoryNotFoundException("Parent directory not found.");
            }

            // Read the API key file
            byte[] keyBytes = File.ReadAllBytes(Path.Combine(parentDir, "api_key"));
            
            // Convert to string and remove the end of line characters
            return Encoding.UTF8.GetString(keyBytes).Trim();
        }

        public HttpClient InitOpenAIClient()
        {
            return new HttpClient();
        }

        public string GetOpenAIResponseGpt4(string model, string inputText, List<string> contentHistory, string apiKey)
        {
            // var openAiClient = new ChatClient(model: "gpt-4o", apiKey: apiKey);
            var openAiClient = new ChatClient(model: "o3-mini", apiKey: apiKey);
            
            // Combine inputText and contentHistory into a single input
            string combinedInput = string.Join(Environment.NewLine, contentHistory) + Environment.NewLine + inputText;
            
            ChatCompletion completion = openAiClient.CompleteChat(combinedInput);
            return completion.Content[0].Text;
        }
    }
}