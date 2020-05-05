using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFPhotoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);

                graphics.DrawImage(PdfSharp.Drawing.XImage.FromFile(@"C:\Users\leona\Pictures\220582.jpg"), 1, 1, page.Width, page.Height);

                doc.Save("arquivo.pdf");
                System.Diagnostics.Process.Start("arquivo.pdf");


                //Metodo para escrever no pdf
                //var font = new PdfSharp.Drawing.XFont("Arial", 14, PdfSharp.Drawing.XFontStyle.BoldItalic);
                //textFormatter.DrawString("Que belo texto!", font, PdfSharp.Drawing.XBrushes.Red, new PdfSharp.Drawing.XRect(0, 50, page.Width, page.Height));
                //textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;

                //fazer um traçado no pdf
                //graphics.DrawLine(PdfSharp.Drawing.XPens.Blue, 150, 150, 250, 200);

                //fazer um retangulo verde
                //graphics.DrawRoundedRectangle(PdfSharp.Drawing.XPens.Green, PdfSharp.Drawing.XBrushes.LightGreen, 100, 300, 100, 50, 10, 10);
            }

        }
    }
}
