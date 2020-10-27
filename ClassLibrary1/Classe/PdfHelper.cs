using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;
using IronPdf;
using System;

namespace Domain.Classe
{
    public static class PdfHelper {
        public static string PdfToText(string path)
        {
            try
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
            catch(Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao ler o texto do arquivo de caminho:\n{path}");
            }
        }

        public static bool SalvarPdf(string path, string content)
        {
            try
            {
                var Renderer = new HtmlToPdf();
                string css = "<style>*{white-space: pre-wrap}</style>";
                Renderer.RenderHtmlAsPdf(css + content).SaveAs(path);
                return File.Exists(path);
            }catch(Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao tentar salvar o texto no arquivo de caminho:\n{path}");
            }
        }
    }
}
