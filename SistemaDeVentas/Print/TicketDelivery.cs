using iText.Kernel.Exceptions;
using SistemaDeVentas.Productos;
using SistemaDeVentas.Ventas;
using SistemaDeVentas.Ventas.Delivery;
using System;
using System.Collections.Generic;
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
            // Imprimir ticket que tenga 8 cm de ancho 

            printDocument.PrintPage += Print;

            // Ancho y altura en puntos (1 pulgada = 72 puntos, 8 cm = aproximadamente 3.15 pulgadas)
            int Width = cmToPoints(10);
            int Height = cmToPoints(6.2);
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("custom", Width, Height);
            printDocument.Print();
                
        }


        private void Print(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Trebuchet MS", 8);
            float fontHeight = font.GetHeight();
            int startX = 3;
            int startY = 3;
            int offset = 20;

            graphics.DrawString("NOMBRE: " + delivery.ClientName, font, new SolidBrush(Color.Black), startX, startY);
            graphics.DrawString("CELULAR: " + delivery.Phone, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphics.DrawString("DIRECCIÓN: " + delivery.Address, font, new SolidBrush(Color.Black), startX, startY + offset * 2);
            graphics.DrawString("REFERENCIA: " + delivery.Reference, font, new SolidBrush(Color.Black), startX, startY + offset * 3);
            graphics.DrawString("INSTRUCCIONES: " + delivery.Instructions, font, new SolidBrush(Color.Black), startX, startY + offset * 4);
            graphics.DrawString("PRODUCTOS: ", font, new SolidBrush(Color.Black), startX, startY + offset * 5);

            // Definir el alto de la caja de productos
            int productBoxHeight = cmToPoints(1.8); // Ejemplo para una caja de 2 cm de alto
            Rectangle productBox = new Rectangle(startX, startY + offset * 6, printDocument.DefaultPageSettings.PaperSize.Width - startX * 2, productBoxHeight);
            graphics.DrawRectangle(new Pen(Color.Black), productBox);

            // Colocar los productos dentro de la caja, separados por "-" y la cantidad
            string productsLine = "";
            foreach (var product in delivery.products)
            {
                productsLine += " - " + product.Quantity + "x" + product.Description + "\n";
            }
            graphics.DrawString(productsLine, font, new SolidBrush(Color.Black),productBox);

            // Continuar con el resto de los datos
            graphics.DrawString("CONDICIÓN PAGO: " + delivery.PaymentCondition, font, new SolidBrush(Color.Black), startX, startY + offset * 7 + productBoxHeight);
            graphics.DrawString("MONTO: S/ " + delivery.Amount, font, new SolidBrush(Color.Black), startX, startY + offset * 8 + productBoxHeight);
            graphics.DrawString("SALDO A COBRAR: S/ " + delivery.Amount_due, font, new SolidBrush(Color.Black), startX, startY + offset * 9 + productBoxHeight);
        }

        private int cmToPoints(double cm)
        {
            return (int)(cm * 41.25);
        }

    }
}
