using SistemaDeVentas.Productos;
using SistemaDeVentas.Ventas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FontStyle = System.Drawing.FontStyle;

namespace SistemaDeVentas.Print
{
    public class Ticket80mm
    {
        private Sale sale = new Sale();
        private List<ProductSaled> products = new List<ProductSaled>();
        int HeightDocument = 510;
        //constructor
        public Ticket80mm(Sale sale, List <ProductSaled> productsSaled)
        {
            this.sale = sale;
            this.products = productsSaled;
        }

        public void CreateTicket80mm()
        {
            // Imprimir ticket que tenga 8 cm de ancho 
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument1_PrintPage;

            // Ancho y altura en puntos (1 pulgada = 72 puntos, 8 cm = aproximadamente 3.15 pulgadas)
            int Width = 330; // Convertir 8 cm a puntos


            //seleccionar impresora del app.config
            printDocument.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["printerTicket"];

            printDocument.DefaultPageSettings.PaperSize = new PaperSize("custom", Width, HeightDocument);
            printDocument.Print();

        }


        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            //guiones
            string dashes = "-------------------------------------------------------------------------------------------";


            // Fuente para el título
            Font font = new Font("Trebuchet MS", 10, FontStyle.Bold);
            // Fuente para los encabezados
            Font fontHeaders = new Font("Trebuchet MS", 8, FontStyle.Bold);
            // Fuente para los detalles
            Font fontDetails = new Font("Trebuchet MS", 8, FontStyle.Regular);

            loadLogo(e);
            int y = 120; // Posición inicial Y para el primer texto

            //insertar numero de comprobante que es el sale.id

            // Calcular el punto central del texto para el título
            string title = "MARCAS ORIGINALES";
            SizeF titleSize = e.Graphics.MeasureString(title, font);
            float titleX = (e.PageBounds.Width - titleSize.Width) / 2; // Centrado

            // Dibujar el título centrado
            e.Graphics.DrawString(title, font, Brushes.Black, new PointF(titleX, y+=10));

            y += 20; // Incrementar Y para el siguiente texto

            // Calcular el punto central del texto para los detalles
            string details = "Modelos únicos y Exclusivos \r\n" +
                "INSTAGRAM : @Marcas_Origanales\r\n" +
                "WHATSAPP: 902 409 961\r\n" +
                "Comprobante N°: " + sale.Id;
            SizeF detailsSize = e.Graphics.MeasureString(details, fontDetails);

            float detailsX = (e.PageBounds.Width - detailsSize.Width) / 2; // Centrado


            e.Graphics.DrawString(details, fontDetails, Brushes.Black, new PointF(detailsX, y));
            y += 45;
            // Dibujar los detalles centrados
            e.Graphics.DrawString(dashes, fontDetails, Brushes.Black, new PointF(0, y));

            y += 20;

            //anadir datos de la venta

            int maxWidth = 250;  // Ancho máximo para el rectángulo, ajustar según tu configuración de papel

            // Fecha con hora y minutos
            string dateText = "Fecha: ";
            string dateValue = sale.Date.ToString("dd/MM/yyyy HH:mm"); // Formato de fecha con hora
            e.Graphics.DrawString(dateText, fontHeaders, Brushes.Black, new PointF(5, y)); // Encabezado en negrita
            e.Graphics.DrawString(dateValue, fontDetails, Brushes.Black, new PointF(100, y)); // Valor en estilo normal
            y += 20;

            // Cliente
            string clientText = "Cliente: ";
            string clientValue = sale.ClientName;
            e.Graphics.DrawString(clientText, fontHeaders, Brushes.Black, new PointF(5, y)); // Encabezado en negrita
            RectangleF clientRect = new RectangleF(100, y, maxWidth - 65, 100); // Ajusta según el espacio necesario para el nombre
            e.Graphics.DrawString(clientValue, fontDetails, Brushes.Black, clientRect); // Valor en estilo normal
            y += (int)e.Graphics.MeasureString(clientValue, fontDetails, clientRect.Size).Height + 10;

            // Teléfono
            string phoneText = "Telefono: ";
            string phoneValue = sale.Phone;
            e.Graphics.DrawString(phoneText, fontHeaders, Brushes.Black, new PointF(5, y));
            e.Graphics.DrawString(phoneValue, fontDetails, Brushes.Black, new PointF(100, y));
            y += 20;



            // Dirección
            string addressText = "Direccion: ";
            string addressValue = sale.District + " " + sale.Address;
            e.Graphics.DrawString(addressText, fontHeaders, Brushes.Black, new PointF(5, y));
            RectangleF addressRect = new RectangleF(100, y, maxWidth - 65, 100);
            e.Graphics.DrawString(addressValue, fontDetails, Brushes.Black, addressRect);
            y += (int)e.Graphics.MeasureString(addressValue, fontDetails, addressRect.Size).Height + 10;



            // Referencia
            string referenceText = "Referencia: ";
            string referenceValue = sale.Reference;
            e.Graphics.DrawString(referenceText, fontHeaders, Brushes.Black, new PointF(5, y));
            RectangleF referenceRect = new RectangleF(100, y, maxWidth - 65, 100);
            e.Graphics.DrawString(referenceValue, fontDetails, Brushes.Black, referenceRect);
            y += (int)e.Graphics.MeasureString(referenceValue, fontDetails, referenceRect.Size).Height + 10;



            // Tipo de Pago
            string paymentTypeText = "Tipo de Pago: ";
            string paymentTypeValue = sale.PaymentTypeName;
            e.Graphics.DrawString(paymentTypeText, fontHeaders, Brushes.Black, new PointF(5, y));
            e.Graphics.DrawString(paymentTypeValue, fontDetails, Brushes.Black, new PointF(100, y));
            y += 20;


            // Observación
            string observationText = "Observacion: ";
            string observationValue = sale.Observation;
            e.Graphics.DrawString(observationText, fontHeaders, Brushes.Black, new PointF(5, y));
            RectangleF observationRect = new RectangleF(100, y, maxWidth - 95, 100);
            e.Graphics.DrawString(observationValue, fontDetails, Brushes.Black, observationRect);
            y += (int)e.Graphics.MeasureString(observationValue, fontDetails, observationRect.Size).Height + 10;
            //aumentar el tamano del documento




            // Dibujar los dashes
            e.Graphics.DrawString(dashes, fontDetails, Brushes.Black, new PointF(0, y));

            y += 20;

            //anadir encabezados
            e.Graphics.DrawString("Producto", fontHeaders, Brushes.Black, new PointF(5, y));
            e.Graphics.DrawString("Cantidad", fontHeaders, Brushes.Black, new PointF(100, y));
            e.Graphics.DrawString("Precio", fontHeaders, Brushes.Black, new PointF(180, y));
            e.Graphics.DrawString("Total", fontHeaders, Brushes.Black, new PointF(230, y));
            y += 20; // Espacio después de los encabezados

            // Imprimir los productos
            foreach (var product in products)
            {
                // Define el área de dibujo para la descripción con word wrap
                RectangleF descriptionRect = new RectangleF(5, y, 100, 100); // Ajusta el ancho y el alto según sea necesario
                e.Graphics.DrawString(product.Description, fontDetails, Brushes.Black, descriptionRect);

                // Mide el área ocupada por el texto impreso
                SizeF size = e.Graphics.MeasureString(product.Description, fontDetails, new SizeF(100, 100));

                // Dibuja el resto de la información ajustando el 'y' según el tamaño del texto de la descripción
                e.Graphics.DrawString(product.Quantity.ToString(), fontDetails, Brushes.Black, new PointF(100, y));
                e.Graphics.DrawString(product.SalePrice.ToString(), fontDetails, Brushes.Black, new PointF(180, y));
                e.Graphics.DrawString((product.SalePrice * product.Quantity).ToString(), fontDetails, Brushes.Black, new PointF(230, y));

                // Incrementa 'y' para la siguiente entrada, teniendo en cuenta el alto del texto
                y += (int)(Math.Max(size.Height, 20)); // Usa el mayor de 'size.Height' o 20 para asegurar espacio suficiente
                
                //aumentar el tamano del documento

            }

            y += 10; // Espacio después de los productos
            // Mostrar el total
            e.Graphics.DrawString("Total", fontHeaders, Brushes.Black, new PointF(5, y));
            e.Graphics.DrawString(sale.Total.ToString(), fontDetails, Brushes.Black, new PointF(230, y));


            HeightDocument += y;

            //configurar el documento con la nueva altura
            e.PageSettings.PaperSize = new PaperSize("custom", 330, HeightDocument);
        }

        private void loadLogo(PrintPageEventArgs e)
        {
            // Cargar el logo desde los recursos
            Image logo = Properties.Resources.logoMarcasOriginales;

            // Determinar el nuevo tamaño del logo
            int logoWidth = logo.Width / 2;  // Reducir a la mitad del tamaño original
            int logoHeight = logo.Height / 2;  // Reducir a la mitad del tamaño original

            // Calcular la posición para centrar el logo
            int logoX = (e.PageBounds.Width - logoWidth) / 2;
            int logoY = 10;  // Posición Y inicial para el logo

            // Crear un rectángulo para el logo con el nuevo tamaño
            Rectangle logoRect = new Rectangle(logoX, logoY, logoWidth, logoHeight);

            // Dibujar el logo redimensionado y centrado
            e.Graphics.DrawImage(logo, logoRect);
        }
    }



}

