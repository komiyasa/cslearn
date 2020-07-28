using System;
using Azure;
using System.Globalization;
using Azure.AI.TextAnalytics;

namespace _51TextAnalytics
{
    public class TextAnalyticsClass
    {
        public static readonly AzureKeyCredential credentials = new AzureKeyCredential("8ae040a56aad4357adce4b11f1fa4f9a");
        public static readonly Uri endpoint = new Uri("https://japaneast.api.cognitive.microsoft.com/");

        public static void SentimentAnalysisExample(TextAnalyticsClient client)
        {
            string inputText = "I had the best day of my life. I wish you were there with me.";
            DocumentSentiment documentSentiment = client.AnalyzeSentiment(inputText);
            Console.WriteLine($"Document sentiment: {documentSentiment.Sentiment}\n");

            foreach (var sentence in documentSentiment.Sentences)
            {
                Console.WriteLine($"\tText: \"{sentence.Text}\"");
                Console.WriteLine($"\tSentence sentiment: {sentence.Sentiment}");
                Console.WriteLine($"\tPositive score: {sentence.ConfidenceScores.Positive:0.00}");
                Console.WriteLine($"\tNegative score: {sentence.ConfidenceScores.Negative:0.00}");
                Console.WriteLine($"\tNeutral score: {sentence.ConfidenceScores.Neutral:0.00}\n");
            }
        }
        public void RunAnalytics()
        {
            var client = new TextAnalyticsClient(endpoint, credentials);
            SentimentAnalysisExample(client);
        }
    }
}
