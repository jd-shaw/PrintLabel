using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrintLabel.PaperHelper
{
    public class PaperHelper
    {

        protected PaperHelper()
        {
            return;
        }


        [Obsolete]
        public static Size GetPaperSize(PageMediaSizeName pageSizeName)
        {
            System.Windows.Controls.PrintDialog printDlg = new System.Windows.Controls.PrintDialog();
            PageMediaSize pageMediaSize = new PageMediaSize(pageSizeName);
            printDlg.PrintTicket.PageMediaSize = pageMediaSize;

            return new Size(printDlg.PrintableAreaWidth, printDlg.PrintableAreaHeight);
        }

        [Obsolete]
        public static Size GetPaperSize(PageMediaSizeName pageSizeName, PrintLabel.PrintSettings.PageOrientation pageOrientation)
        {
            System.Windows.Controls.PrintDialog printDlg = new System.Windows.Controls.PrintDialog();
            PageMediaSize pageMediaSize = new PageMediaSize(pageSizeName);
            printDlg.PrintTicket.PageMediaSize = pageMediaSize;

            if (pageOrientation == PrintLabel.PrintSettings.PageOrientation.Portrait)
            {
                return new Size(printDlg.PrintableAreaWidth, printDlg.PrintableAreaHeight);
            }
            else
            {
                return new Size(printDlg.PrintableAreaHeight, printDlg.PrintableAreaWidth);
            }
        }

        public static Size GetPaperSize(double CMWidth, double CMHeight)
        {
            double cm = 37.7952755905512;
            return new Size(CMWidth * cm / 10, CMHeight * cm / 10);
        }

        public static Size GetPaperSize(PageMediaSizeName pageSizeName, bool isAdvanced)
        {
            System.Windows.Controls.PrintDialog printDlg = new System.Windows.Controls.PrintDialog();
            PageMediaSize pageMediaSize = new PageMediaSize(pageSizeName);
            printDlg.PrintTicket.PageMediaSize = pageMediaSize;

            if (isAdvanced)
            {
                List<Size> printableAreaSize = new List<Size>();

                foreach (PrintQueue printer in PrinterHelper.PrinterHelper.GetLocalPrinters())
                {
                    printDlg.PrintQueue = printer;
                    printableAreaSize.Add(new Size((int)printDlg.PrintableAreaWidth, (int)printDlg.PrintableAreaHeight));
                }

                return printableAreaSize.GroupBy(i => i).OrderByDescending(group => group.Count()).Select(group => group.Key).First();
            }
            else
            {
                return new Size(printDlg.PrintableAreaHeight, printDlg.PrintableAreaWidth);
            }
        }

        public static Size GetPaperSize(PageMediaSizeName pageSizeName, PrintQueue printQueue)
        {
            System.Windows.Controls.PrintDialog printDlg = new System.Windows.Controls.PrintDialog();
            PageMediaSize pageMediaSize = new PageMediaSize(pageSizeName);
            printDlg.PrintQueue = printQueue;
            printDlg.PrintTicket.PageMediaSize = pageMediaSize;

            return new Size(printDlg.PrintableAreaWidth, printDlg.PrintableAreaHeight);
        }

        public static Size GetPaperSize(PageMediaSizeName pageSizeName, PrintSettings.PageOrientation pageOrientation, bool isAdvanced)
        {
            System.Windows.Controls.PrintDialog printDlg = new System.Windows.Controls.PrintDialog();
            PageMediaSize pageMediaSize = new PageMediaSize(pageSizeName);
            printDlg.PrintTicket.PageMediaSize = pageMediaSize;

            if (isAdvanced)
            {
                List<Size> printableAreaSize = new List<Size>();

                foreach (PrintQueue printer in PrintLabel.PrinterHelper.PrinterHelper.GetLocalPrinters())
                {
                    printDlg.PrintQueue = printer;
                    printableAreaSize.Add(new Size((int)printDlg.PrintableAreaWidth, (int)printDlg.PrintableAreaHeight));
                }

                Size size = printableAreaSize.GroupBy(i => i).OrderByDescending(group => group.Count()).Select(group => group.Key).First();

                if (pageOrientation == PrintSettings.PageOrientation.Portrait)
                {
                    return size;
                }
                else
                {
                    return new Size(size.Height, size.Width);
                }
            }
            else
            {
                if (pageOrientation == PrintSettings.PageOrientation.Portrait)
                {
                    return new Size(printDlg.PrintableAreaWidth, printDlg.PrintableAreaHeight);
                }
                else
                {
                    return new Size(printDlg.PrintableAreaHeight, printDlg.PrintableAreaWidth);
                }
            }
        }

        public static Size GetPaperSize(PageMediaSizeName pageSizeName, PrintSettings.PageOrientation pageOrientation, PrintQueue printQueue)
        {
            System.Windows.Controls.PrintDialog printDlg = new System.Windows.Controls.PrintDialog();
            PageMediaSize pageMediaSize = new PageMediaSize(pageSizeName);
            printDlg.PrintQueue = printQueue;
            printDlg.PrintTicket.PageMediaSize = pageMediaSize;

            if (pageOrientation == PrintSettings.PageOrientation.Portrait)
            {
                return new Size(printDlg.PrintableAreaWidth, printDlg.PrintableAreaHeight);
            }
            else
            {
                return new Size(printDlg.PrintableAreaHeight, printDlg.PrintableAreaWidth);
            }
        }
    }

    public class PaperSize
    {
        protected PaperSize()
        {
            return;
        }

        public static double A1Width { get; } = 594;

        public static double A1Height { get; } = 841;

        public static double A2Width { get; } = 420;

        public static double A2Height { get; } = 594;

        public static double A3Width { get; } = 297;

        public static double A3Height { get; } = 420;

        public static double A4Width { get; } = 210;

        public static double A4Height { get; } = 297;

        public static double A5Width { get; } = 148;

        public static double A5Height { get; } = 210;

        public static double A6Width { get; } = 105;

        public static double A6Height { get; } = 148;

        public static double GetLengthWithName(string name)
        {
            foreach (PropertyInfo item in typeof(PaperSize).GetProperties(BindingFlags.Instance | BindingFlags.Static))
            {
                if (item.Name.ToLower() == name.Trim().ToLower())
                {
                    return (double)item.GetValue(new PaperSize());
                }
            }

            return double.NaN;
        }
    }
}
