using CSTPlaca.CrossCutting.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CSTPlaca.Service
{
    public class ExportPdfService
    {
        public async Task<byte[]> ExportarParaPdf(ApiPlacaModel model)
        {
            // Crie um novo documento PDF
            var doc = new Document();

            // Crie um novo MemoryStream e PdfWriter. Note que o PdfWriter é criado com o MemoryStream
            // e o Documento PDF.
            using (var stream = new MemoryStream())
            {
                var pdfWriter = PdfWriter.GetInstance(doc, stream);
                pdfWriter.CloseStream = false;

                // Abra o Documento PDF para escrever dados
                doc.Open();

                // Adicione os dados do seu modelo ao Documento PDF aqui.
                // Isso pode variar dependendo da complexidade do seu modelo e como você deseja representá-lo no PDF.
                // Por exemplo:
                doc.Add(new Paragraph("Marca: " + model.Marca));
                doc.Add(new Paragraph("Modelo: " + model.Modelo));
                doc.Add(new Paragraph("Modelo: " + model.Submodelo));
                // ... Adicione mais campos conforme necessário.

                // Feche o Documento PDF
                doc.Close();

                byte[] bytes = stream.ToArray();

                // Retorne o PDF como um array de bytes.
                return bytes;
            }
        }

    }
}
