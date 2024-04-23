using iText.Kernel.Exceptions;
using SistemaDeVentas.Productos;
using SistemaDeVentas.Ventas;
using SistemaDeVentas.Ventas.Delivery;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SistemaDeVentas.Print
{
    public class TicketDelivery
    {
        private Delivery delivery;
        PrintDocument printDocument = new PrintDocument();

        public TicketDelivery(Delivery delivery)
        {
            this.delivery = delivery;
        }

        public void createTicketDelivery()
        {


            //seleccionar la impresora del app.config
            printDocument.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["printerDelivery"];

            printDocument.PrintPage += Print;

            // Ancho y altura en puntos (1 pulgada = 72 puntos, 8 cm = aproximadamente 3.15 pulgadas)
            int Width = cmToPoints(7);
            int Height = cmToPoints(5);

            printDocument.DefaultPageSettings.PaperSize = new PaperSize("custom", Width, Height);
            printDocument.Print();

        }


        private void Print(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Trebuchet MS", 8);
            int startX = 3;
            int startY = 3;
            int offset = 14;

            graphics.DrawString("NOMBRE: " + delivery.ClientName, font, new SolidBrush(Color.Black), startX, startY);
            graphics.DrawString("CELULAR: " + delivery.Phone, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphics.DrawString("DIRECCIÓN: " + delivery.District + " " + delivery.Address, font, new SolidBrush(Color.Black), startX, startY + offset * 2);
            graphics.DrawString("REFERENCIA: " + delivery.Reference, font, new SolidBrush(Color.Black), startX, startY + offset * 3);
            graphics.DrawString("INSTRUCCIONES: " + delivery.Instructions, font, new SolidBrush(Color.Black), startX, startY + offset * 4);
            graphics.DrawString("PRODUCTOS: ", font, new SolidBrush(Color.Black), startX, startY + offset * 5);

            // Definir el alto de la caja de productos
            int productBoxHeight = cmToPoints(1.5);
            Rectangle productBox = new Rectangle(startX, startY + offset * 6, printDocument.DefaultPageSettings.PaperSize.Width - startX * 10, productBoxHeight);
            graphics.DrawRectangle(new Pen(Color.Black), productBox);

            // Colocar los productos dentro de la caja
            string productsLine = "";
            foreach (var product in delivery.products)
            {
                productsLine += " - " + product.Quantity + "x" + product.Description + "\n";
            }
            graphics.DrawString(productsLine, font, new SolidBrush(Color.Black), productBox);

            // Dibuja el monto y saldo a cobrar al lado
            string amountText = "MONTO: S/ " + delivery.Amount;
            string amountDueText = "S. A COBRAR: S/ " + delivery.Amount_due;

            // Obtener el ancho del texto MONTO
            SizeF amountTextSize = graphics.MeasureString(amountText, font);
            int amountTextWidth = (int)amountTextSize.Width;

            // Dibujar MONTO
            graphics.DrawString(amountText, font, new SolidBrush(Color.Black), startX, startY + offset * 7 + productBoxHeight);

            // Dibujar SALDO A COBRAR justo al lado
            graphics.DrawString(amountDueText, font, new SolidBrush(Color.Black), startX + amountTextWidth + 20, startY + offset * 7 + productBoxHeight);  // Ajusta el '10' si se necesita más espacio entre textos
        }


        private int cmToPoints(double cm)
        {
            return (int)(cm * 41.25);
        }

    }
}
