using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexOrder
{
    public class PrintHelper
    {
        private Order _order;
        private List<Bitmap> _tickets;
        private int _printIndex = 0;
        public void PrintReceipt(Order order)
        {
            _tickets = new List<Bitmap>();
            _printIndex = 0;

            foreach (var d in order.orderdetaillist)
            {
                for (int i = 0; i < d.quantity; i++)
                {
                    MealTicket ticket = new MealTicket();
                    ticket.Bind(order, d);

                    _tickets.Add(RenderMealTicket(ticket));
                }
            }
            if (order.orderdetaillist.Count > 0)
            {
                PrintDocument pd = new PrintDocument();
                foreach (string printer in PrinterSettings.InstalledPrinters)
                {
                    Console.WriteLine(printer);
                }
                try {
                    //pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                    if (!pd.PrinterSettings.IsValid)
                    {
                        Console.WriteLine("Printer doesn't exist");
                    }
                    pd.PrintPage += Pd_PrintPage;
                    pd.Print();
                } catch (Exception ex) {
                    Console.WriteLine(ex.ToString());
                }
            }
            else 
            {
                Console.WriteLine("No detail in Order. Print Skipped");
            }

        }
        private Bitmap RenderMealTicket(MealTicket ticket)
        {
            Bitmap bmp = new Bitmap(ticket.Width, ticket.Height);
            ticket.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }
        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(_tickets[_printIndex], 0, 0);
            _printIndex++;
            e.HasMorePages = _printIndex < _tickets.Count;
        }


    }
}
