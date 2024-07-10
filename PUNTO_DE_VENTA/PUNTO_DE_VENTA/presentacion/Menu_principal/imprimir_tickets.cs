using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.presentacion.Menu_principal
{
   public  class imprimir_tickets
    {
        private int m_currentPageIndex;
        private IList<Stream> m_streams;

        // Stream que nos ayudara a contener el Report.rdlc 
        private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        // exportacion del archivo-reporte en formato EMF (Enhanced Metafile).
        private void Export(LocalReport report)
        {
            //las siguientes lineas definen el tamaño de la hoja, en mi caso es de tamaño ticket
            //los tamaños pueden ser en pulgadas(in) o en centimetros(cm), quiza aceptan mas formatos pero no los probé.
            string deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>9cm</PageWidth>
                <PageHeight>20cm</PageHeight>
                <MarginTop>0.2cm</MarginTop>
                <MarginLeft>0,1cm</MarginLeft>
                <MarginRight>0.1cm</MarginRight>
                <MarginBottom>0cm</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            //renderizamos el reporte
            report.Render("Image", deviceInfo, CreateStream, out warnings);
            foreach (Stream stream in m_streams)
            { stream.Position = 0; }
        }

        // Handler para los eventos PrintPageEvents
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new Metafile(m_streams[m_currentPageIndex]);

            // ajusta el area rectangular con margenes.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Dibuja un fondo blanco para el reporte
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Dibuja el contenido del reporte
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // pasa a la siguiente pagina y comprueba que no se haya terminado el contenido
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }
        public String printerName;
        public void Print()
        {
            PrintDocument printDoc;
            //busca el nombre de la impresora predeterminada
         

            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: No hay datos que imprimir.");

            printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = printerName;
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception(String.Format("No puedo encontrar la impresora \"{0}\".", printerName));
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

     

        // Exporta el reporte a un archivo .emf y lo imprime
        public void Imprime(LocalReport rdlc)
        {
            Export(rdlc);
            Print();
        }

        public void Dispose()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }
    }
}
