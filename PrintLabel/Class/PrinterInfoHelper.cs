using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PrintLabel.PrinterInfoHelper
{
    internal class PrinterIconHelper
    {
        protected PrinterIconHelper()
        {
            return;
        }

        public static readonly Uri NormalPrinterIcon = new Uri("/PrintLabel;component/Resources/PrinterIcons/Normal.png", UriKind.Relative);
        public static readonly Uri NormalDefaultPrinterIcon = new Uri("/PrintLabel;component/Resources/PrinterIcons/Normal (Default).png", UriKind.Relative);
        public static readonly Uri FaxPrinterIcon = new Uri("/PrintLabel;component/Resources/PrinterIcons/Fax.png", UriKind.Relative);
        public static readonly Uri FaxDefaultPrinterIcon = new Uri("/PrintLabel;component/Resources/PrinterIcons/Fax (Default).png", UriKind.Relative);
        public static readonly Uri NetworkFaxPrinterIcon = new Uri("/PrintLabel;component/Resources/PrinterIcons/Network Fax.png", UriKind.Relative);
        public static readonly Uri NetworkFaxDefaultPrinterIcon = new Uri("/PrintLabel;component/Resources/PrinterIcons/Network Fax (Default).png", UriKind.Relative);
        public static readonly Uri NormalPrinterSmallIcon = new Uri("/PrintLabel;component/Resources/PrinterIcons/Normal - Small.png", UriKind.Relative);
        public static readonly Uri NormalDefaultPrinterSmallIcon = new Uri("/PrintLabel;component/Resources/PrinterIcons/Normal (Default) - Small.png", UriKind.Relative);
        public static readonly Uri FaxPrinterSmallIcon = new Uri("/PrintLabel;component/Resources/PrinterIcons/Fax - Small.png", UriKind.Relative);
        public static readonly Uri FaxDefaultPrinterSmallIcon = new Uri("/PrintLabel;component/Resources/PrinterIcons/Fax (Default) - Small.png", UriKind.Relative);
        public static readonly Uri NetworkFaxPrinterSmallIcon = new Uri("/PrintLabel;component/Resources/PrinterIcons/Network Fax - Small.png", UriKind.Relative);
        public static readonly Uri NetworkFaxDefaultPrinterSmallIcon = new Uri("/PrintLabel;component/Resources/PrinterIcons/Network Fax (Default) - Small.png", UriKind.Relative);

        public static ImageSource GetPrinterIcon(PrintQueue printer, PrintServer printServer, bool smallIcon = false)
        {
            string printerType = "Normal";

            foreach (PrintQueue printQueue in printServer.GetPrintQueues(new EnumeratedPrintQueueTypes[] { EnumeratedPrintQueueTypes.Fax }))
            {
                if (printQueue.FullName == printer.FullName)
                {
                    printerType = "Fax";
                    break;
                }
            }

            if (printerType == "Fax")
            {
                if (printer.IsShared == true)
                {
                    printerType = "NetworkFax";
                }
            }

            if (LocalPrintServer.GetDefaultPrintQueue().FullName == printer.FullName)
            {
                printerType += "_Default";
            }
            if (smallIcon == true)
            {
                printerType += "_Small";
            }

            switch (printerType)
            {
                case "Normal": return new BitmapImage(NormalPrinterIcon);
                case
                "Normal_Default":
                    return new BitmapImage(NormalDefaultPrinterIcon);
                case
                "Fax":
                    return new BitmapImage(FaxPrinterIcon);
                case
                "Fax_Default":
                    return new BitmapImage(FaxDefaultPrinterIcon);
                case
                "NetworkFax":
                    return new BitmapImage(NetworkFaxPrinterIcon);
                case
                "NetworkFax_Default":
                    return new BitmapImage(NetworkFaxDefaultPrinterIcon);
                case

                "Normal_Small":
                    return new BitmapImage(NormalPrinterSmallIcon);
                case
                "Normal_Default_Small":
                    return new BitmapImage(NormalDefaultPrinterSmallIcon);
                case
                "Fax_Small":
                    return new BitmapImage(FaxPrinterSmallIcon);
                case
                "Fax_Default_Small":
                    return new BitmapImage(FaxDefaultPrinterSmallIcon);
                case
                "NetworkFax_Small":
                    return new BitmapImage(NetworkFaxPrinterSmallIcon);
                case
                "NetworkFax_Default_Small":
                    return new BitmapImage(NetworkFaxDefaultPrinterSmallIcon);

                default:
                    return new BitmapImage(NormalPrinterIcon);
            }
        }
    }
}
