using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace LogicaCripto
{
    public static class PdfParse
    {
        public static string PdfToText(string path)
        {
            PdfReader reader = new PdfReader(path);
            string text = string.Empty;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page);
            }
            reader.Close();
            return text;
        }
    }
}
