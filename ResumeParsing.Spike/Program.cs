using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
namespace ResumeParsing.Spike;

public static class Program
{
    public static void Main(string[] args)
    {
        using PdfDocument document = PdfDocument.Open("PDF/sample-resume-2022.pdf");
            foreach (Page page in document.GetPages())
            {
                IReadOnlyList<Letter> letters = page.Letters;
                string ex = string.Join(string.Empty, letters.Select((x => x.Value)));
                
                IEnumerable<Word> words = page.GetWords();
                
                Console.WriteLine("=== Letters joined ===");
                Console.WriteLine(ex);

                Console.WriteLine("=== Words ===");
                Console.WriteLine(string.Join(" ", words.Select(w => w.Text)));
                
            }
    }
}