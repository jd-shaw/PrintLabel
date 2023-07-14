using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace PrintLabel.PrinterHelper
{
    public class PrinterHelper
    {
       
        protected PrinterHelper()
        {
            return;
        }

   
        public static PrintQueue GetPrinterByName(string printerName)
        {
            return new PrintServer().GetPrintQueue(printerName);
        }

  
        public static PrintQueue GetPrinterByName(string printerName, PrintServer printServer)
        {
            return printServer.GetPrintQueue(printerName);
        }


        public static PrintQueue GetDefaultPrinter()
        {
            return LocalPrintServer.GetDefaultPrintQueue();
        }

        public static PrintQueueCollection GetLocalPrinters()
        {
            return GetLocalPrinters(new PrintServer());
        }

        public static PrintQueueCollection GetLocalPrinters(EnumeratedPrintQueueTypes[] enumerationFlag)
        {
            return GetLocalPrinters(new PrintServer(), enumerationFlag);
        }

        public static PrintQueueCollection GetLocalPrinters(PrintServer server)
        {
            return server.GetPrintQueues();
        }


        public static PrintQueueCollection GetLocalPrinters(PrintServer server, EnumeratedPrintQueueTypes[] enumerationFlag)
        {
            return server.GetPrintQueues(enumerationFlag);
        }

        public static string GetPrinterStatusInfo(string printerName)
        {
            return GetPrinterStatusInfo(new PrintServer().GetPrintQueue(printerName));
        }


        public static string GetPrinterStatusInfo(PrintQueue printer)
        {
            printer.Refresh();

            return GetPrinterStatusInfo(printer.QueueStatus);
        }

        public static string GetPrinterStatusInfo(PrintQueueStatus printerStatue)
        {
            switch (printerStatue) {
                case PrintQueueStatus.Busy: return "Busy";
                case
                PrintQueueStatus.DoorOpen:
                    return "Door Open";
                case
                PrintQueueStatus.Error:
                    return "Error";
                case
                PrintQueueStatus.Initializing:
                    return "Initializing";
                case
                PrintQueueStatus.IOActive:
                    return "Exchanging Data";
                case
                PrintQueueStatus.ManualFeed:
                    return "Need Manual Feed";
                case
                PrintQueueStatus.NoToner:
                    return "No Toner";
                case
                PrintQueueStatus.Offline:
                    return "Offline";
                case
                PrintQueueStatus.OutOfMemory:
                    return "Out Of Memory";
                case
                PrintQueueStatus.OutputBinFull:
                    return "Output Bin Full";
                case
                PrintQueueStatus.PagePunt:
                    return "Page Punt";
                case
                PrintQueueStatus.PaperJam:
                    return "Paper Jam";
                case
                PrintQueueStatus.PaperOut:
                    return "Paper Out";
                case
                PrintQueueStatus.PaperProblem:
                    return "Paper Error";
                case
                PrintQueueStatus.Paused:
                    return "Paused";
                case
                PrintQueueStatus.PendingDeletion:
                    return "Deleting Job";
                case
                PrintQueueStatus.PowerSave:
                    return "Power Save";
                case
                PrintQueueStatus.Printing:
                    return "Printing";
                case
                PrintQueueStatus.Processing:
                    return "Processing";
                case
                PrintQueueStatus.ServerUnknown:
                    return "Server Unknown";
                case
                PrintQueueStatus.TonerLow:
                    return "Toner Low";
                case
                PrintQueueStatus.UserIntervention:
                    return "Need User Intervention";
                case
                PrintQueueStatus.Waiting:
                    return "Waiting";
                case
                PrintQueueStatus.WarmingUp:
                    return "Warming Up";
                default: return "Ready"; }
        }

   
        public static void InstallPrinter(string printerName, string driverName, string[] portNames, string printerProcessorName, PrintQueueAttributes printerProperties)
        {
            LocalPrintServer localPrintServer = new LocalPrintServer();
            localPrintServer.InstallPrintQueue(printerName, driverName, portNames, printerProcessorName, printerProperties);
            localPrintServer.Commit();
        }

     
        public static void InstallPrinter(PrintServer printServer, string printerName, string driverName, string[] portNames, string printerProcessorName, PrintQueueAttributes printerProperties)
        {
            printServer.InstallPrintQueue(printerName, driverName, portNames, printerProcessorName, printerProperties);
            printServer.Commit();
        }

     public static void InstallPrinter(PrintServer printServer, string printerName, string driverName, string[] portNames, string printerProcessorName, PrintQueueAttributes printerProperties, string printerShareName, string printerComment, string printerLoction, string printerSeparatorFile, int printerPriority, int printerDefaultPriority)
        {
            printServer.InstallPrintQueue(printerName, driverName, portNames, printerProcessorName, printerProperties, printerShareName, printerComment, printerLoction, printerSeparatorFile, printerPriority, printerDefaultPriority);
            printServer.Commit();
        }
    }

    public class PrintJobHelper
    {
  
        protected PrintJobHelper()
        {
            return;
        }


        public static PrintJobInfoCollection GetPrintJobs(string printerName)
        {
            PrintQueue printer = new PrintServer().GetPrintQueue(printerName);
            printer.Refresh();

            return printer.GetPrintJobInfoCollection();
        }

      
        public static PrintJobInfoCollection GetPrintJobs(PrintQueue printer)
        {
            printer.Refresh();

            return printer.GetPrintJobInfoCollection();
        }

    
        public static PrintJobInfoCollection GetPrintJobs(PrintQueue printer, string submitter)
        {
            printer.Refresh();

            PrintJobInfoCollection printJobList = new PrintJobInfoCollection(printer, null);

            foreach (PrintSystemJobInfo jobInfo in printer.GetPrintJobInfoCollection())
            {
                if (jobInfo.Submitter == submitter)
                {
                    printJobList.Add(jobInfo);
                }
            }

            return printJobList;
        }

        public static PrintJobInfoCollection GetErrorPrintJobs(string printerName)
        {
            return GetErrorPrintJobs(new PrintServer().GetPrintQueue(printerName), false);
        }


        public static PrintJobInfoCollection GetErrorPrintJobs(PrintQueue printer)
        {
            return GetErrorPrintJobs(printer, false);
        }

        public static PrintJobInfoCollection GetErrorPrintJobs(PrintQueue printer, bool isCancel)
        {
            printer.Refresh();

            PrintJobInfoCollection errorList = new PrintJobInfoCollection(printer, null);

            foreach (PrintSystemJobInfo jobInfo in printer.GetPrintJobInfoCollection())
            {
                if (jobInfo.JobStatus == PrintJobStatus.Blocked || jobInfo.JobStatus == PrintJobStatus.Error || jobInfo.JobStatus == PrintJobStatus.Offline || jobInfo.JobStatus == PrintJobStatus.PaperOut || jobInfo.JobStatus == PrintJobStatus.UserIntervention)
                {
                    errorList.Add(jobInfo);

                    if (isCancel)
                    {
                        jobInfo.Cancel();
                        jobInfo.Commit();
                    }
                }
            }

            return errorList;
        }


        public static PrintJobInfoCollection GetErrorPrintJobs(PrintQueue printer, string submitter)
        {
            return GetErrorPrintJobs(printer, submitter, false);
        }


        public static PrintJobInfoCollection GetErrorPrintJobs(PrintQueue printer, string submitter, bool isCancel)
        {
            printer.Refresh();

            PrintJobInfoCollection errorList = new PrintJobInfoCollection(printer, null);

            foreach (PrintSystemJobInfo jobInfo in printer.GetPrintJobInfoCollection())
            {
                if (jobInfo.Submitter == submitter)
                {
                    if (jobInfo.JobStatus == PrintJobStatus.Blocked || jobInfo.JobStatus == PrintJobStatus.Error || jobInfo.JobStatus == PrintJobStatus.Offline || jobInfo.JobStatus == PrintJobStatus.PaperOut || jobInfo.JobStatus == PrintJobStatus.UserIntervention)
                    {
                        errorList.Add(jobInfo);

                        if (isCancel)
                        {
                            jobInfo.Cancel();
                            jobInfo.Commit();
                        }
                    }
                }
            }

            return errorList;
        }
    }
}
