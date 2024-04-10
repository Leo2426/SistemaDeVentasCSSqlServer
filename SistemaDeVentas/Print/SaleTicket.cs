using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using SistemaDeVentas.Properties;
using SistemaDeVentas.Ventas;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;


namespace SistemaDeVentas.Print
{
    public class SaleTicket
    {

        private Sale sale = new Sale();
        private List<ProductSaled> products = new List<ProductSaled>();

        public SaleTicket(Sale sale,List<ProductSaled> products)
        {
            this.sale = sale;
            this.products = products;
        }


        public void CreateSaleTicketPdf()
        {
            string nameofpdf = sale.Id.ToString();
            string dest = GetSaveFilePath(nameofpdf);
            if (string.IsNullOrEmpty(dest))
            {
                // El usuario canceló el diálogo o no seleccionó un archivo.
                return;
            }

            float height = 280f;

            string html = Properties.Resources.saleTicket.ToString();

            html = html.Replace("@Client",sale.ClientName);
            html = html.Replace("@Phone",sale.Phone);
            html = html.Replace("@Address",sale.Address);
            html = html.Replace("@Reference",sale.Reference);
            html = html.Replace("@Observation",sale.Observation);
            html = html.Replace("@PaymentType",sale.PaymentTypeName);
            html = html.Replace("@Date",sale.Date.ToString());
            html = html.Replace("@Total",sale.Total.ToString());

            string productsHtml = "";




            foreach (var product in products)
            {
                productsHtml += "<tr>";
                productsHtml += "<td>" + product.Description + "</td>";
                productsHtml += "<td>" + product.Quantity + "</td>";
                productsHtml += "<td>" + product.SalePrice + "</td>";
                productsHtml += "<td>" + product.SalePrice * product.Quantity + "</td>";
                productsHtml += "</tr>";
                height += 20f;
            }


            // Reemplazar la etiqueta @Products en el HTML con la tabla de productos
            html = html.Replace("@Products", productsHtml);


            //crea el documento pdf con 8cm de ancho y el alto variable
            // Definir el ancho en puntos (8 cm)
            float widthInCm = 8f; // ancho en centímetros
            float widthInPoints = widthInCm * (72f / 2.54f); // convertir a puntos

            Rectangle PageSize()
            {
                return new Rectangle(widthInPoints, height);
            }

            Document pdfDoc = new Document(PageSize(),10f,10f,10f,10f);
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(dest, FileMode.Create));

            pdfDoc.Open();

            insertImage(pdfDoc);


            using (TextReader sr = new StringReader(html))
            {
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
            }

            pdfDoc.Close();

            MessageBox.Show("Ticket de Venta guardado correctamente en: " + dest);


            //abrir el pdf
            // Abre el archivo PDF generado
            if (File.Exists(dest))
            {
                Process.Start(new ProcessStartInfo(dest) { UseShellExecute = true });
            }


            pressCtrlP(dest);

        }

        private void pressCtrlP(string dest)
        {
            // Abre el archivo PDF generado con la aplicación predeterminada
            ProcessStartInfo psi = new ProcessStartInfo(dest)
            {
                UseShellExecute = true
            };
            Process process = Process.Start(psi);

            // Espera un momento para que el archivo PDF se abra
            Thread.Sleep(2000); // Espera 2 segundos

            // Simula la presión de la tecla Control + P
            SendKeys.SendWait("^(p)"); // '^' representa la tecla Control, y 'p' es la tecla 'P'

            // Nota: Este enfoque depende del contexto actual y de la aplicación que tenga el foco. Puede que no funcione como se espera en todos los casos.

        }

        private void insertImage(Document pdf)
        {
            //insertar logo
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Properties.Resources.logoMarcasOriginales, BaseColor.WHITE);
            logo.ScaleAbsolute(80f, 80f);
            logo.Alignment = Element.ALIGN_CENTER;
            pdf.Add(logo);
        }

        private static string GetSaveFilePath(string name)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "PDF files (*.pdf)|*.pdf"; // Filtra solo archivos .pdf
                dialog.Title = "Guardar Ticket de Venta como PDF";
                //guardar con nombre predefinido
                dialog.FileName = "TicketVenta_" + name + "_"+DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.FileName; // Retorna la ruta completa del archivo
                }
                else
                {
                    return null; // El usuario canceló o cerró el diálogo
                }
            }
        }


    }
}

