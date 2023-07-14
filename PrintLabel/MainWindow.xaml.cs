using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrintLabel
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        PrintLabel.PrintDialog.PrintDialog printDialog;

        private PrintPage printPage;


        private void mainFrame_Loaded(object sender, RoutedEventArgs e)
        {

            printDialog = new PrintLabel.PrintDialog.PrintDialog
            {
                Owner = this,
                Icon = null,
                Topmost = false,
                ShowInTaskbar = true,
                ResizeMode = ResizeMode.NoResize,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };
            this.UpdateLayout();
            PrintPage.DoEvents();

            GeneratingDocument(this);

        }

        private void GeneratingDocument(MainWindow mainWindow)
        {
            //Create a new document (a document contains many pages)
            //PrintDialog can only print and preview a FixedDocument
            //Here are some codes to make a document, if you already know how to do it, you can skip it or put your document instead
            FixedDocument fixedDocument = new FixedDocument();
            fixedDocument.DocumentPaginator.PageSize = PrintLabel.PaperHelper.PaperHelper.GetPaperSize(System.Printing.PageMediaSizeName.ISOA4, true); //Use PaperHelper class to get A4 page size

            //Define document inner margin;
            double margin = 60;

            //Loop 5 times to add 5 pages.
            for (int i = 0; i < 5; i++)
            {
                //Create a new page and set its size
                //Page's size is equals document's size
                FixedPage fixedPage = new FixedPage()
                {
                    Width = fixedDocument.DocumentPaginator.PageSize.Width,
                    Height = fixedDocument.DocumentPaginator.PageSize.Height
                };

                //Create a StackPanel and make it cover entire page
                StackPanel stackPanel = CreateContent(fixedDocument.DocumentPaginator.PageSize.Width, fixedDocument.DocumentPaginator.PageSize.Height, margin);

                //Add the StackPanel into the page
                //You can add as many elements as you want into the page, but at here we only need to add one
                fixedPage.Children.Add(stackPanel);

                //Add the page into the document
                //You can't just add FixedPage into FixedDocument, you need use PageContent to host the FixedPage
                fixedDocument.Pages.Add(new PageContent() { Child = fixedPage });
            }

            //Setup PrintDialog's properties
            printDialog.Document = fixedDocument; //Set document that need to print
            printDialog.DocumentName = "Test Document"; //Set document name that will display in print list.
            printDialog.DocumentMargin = margin; //Set document margin info.
            printDialog.DefaultSettings = new PrintDialog.PrintDialogSettings() //Set default settings. Or you can just use PrintDialog.PrintDialogSettings.PrinterDefaultSettings() to get a PrintDialogSettings that use printer default settings
            {
                Layout = PrintSettings.PageOrientation.Portrait,
                Color = PrintSettings.PageColor.Color,
                Quality = PrintSettings.PageQuality.Normal,
                PageSize = PrintSettings.PageSize.ISOA4,
                PageType = PrintSettings.PageType.Plain,
                TwoSided = PrintSettings.TwoSided.TwoSidedLongEdge,
                PagesPerSheet = 1,
                PageOrder = PrintSettings.PageOrder.Horizontal
            };
            //Or printDialog.DefaultSettings = PrintDialog.PrintDialogSettings.PrinterDefaultSettings()

            printDialog.AllowScaleOption = true; //Allow scale option
            printDialog.AllowPagesOption = true; //Allow pages option (contains "All Pages", "Current Page", and "Custom Pages")
            printDialog.AllowTwoSidedOption = true; //Allow two-sided option
            printDialog.AllowPagesPerSheetOption = true; //Allow pages per sheet option
            printDialog.AllowPageOrderOption = true; //Allow page order option
            printDialog.AllowAddNewPrinterButton = true; //Allow add new printer button in printer list
            printDialog.AllowMoreSettingsExpander = true; //Allow more settings expander
            printDialog.AllowPrinterPreferencesButton = true; //Allow printer preferences button

            printDialog.CustomReloadDocumentMethod = ReloadDocumentMethod; //Set the method that will use to recreate the document when print settings changed.

            printDialog.LoadingEnd(mainWindow);
        }


        private StackPanel CreateContent(double width, double height, double margin)
        {
            StackPanel stackPanel = new StackPanel()
            {
                Orientation = Orientation.Vertical,
                Background = Brushes.LightYellow,
                Width = width - margin * 2, //Width = Page width - (left margin + right margin)
                Height = height - margin * 2 //Height = Page height - (top margin + bottom margin)
            };

            stackPanel.Children.Add(new TextBlock() { Text = "This is the page title", FontWeight = FontWeights.Bold, FontSize = 28, TextAlignment = TextAlignment.Center, Margin = new Thickness(10, 5, 10, 35) });
            stackPanel.Children.Add(new TextBlock() { Text = "These are some regular text.", Margin = new Thickness(10, 5, 10, 5) });
            stackPanel.Children.Add(new TextBlock() { Text = "These are some bold text.", FontWeight = FontWeights.Bold, Margin = new Thickness(10, 5, 10, 5) });
            stackPanel.Children.Add(new TextBlock() { Text = "These are some italic text.", FontStyle = FontStyles.Italic, Margin = new Thickness(10, 5, 10, 5) });
            stackPanel.Children.Add(new TextBlock() { Text = "These are some different colored text.", Foreground = Brushes.Red, Margin = new Thickness(10, 5, 10, 5) });
            stackPanel.Children.Add(new TextBlock()
            {
                Text = "This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph.This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph. This is a very long paragraph.",
                MaxWidth = stackPanel.Width,
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(10, 5, 10, 5)
            });
            stackPanel.Children.Add(new Button() { Content = "This is a button.", Margin = new Thickness(10, 5, 10, 5), Width = 250, Height = 30, VerticalContentAlignment = VerticalAlignment.Center });
            stackPanel.Children.Add(new Button() { Content = "This is a button with different color.", BorderBrush = Brushes.Black, Background = Brushes.DarkGray, Foreground = Brushes.White, Width = 250, Height = 30, VerticalContentAlignment = VerticalAlignment.Center, Margin = new Thickness(10, 5, 10, 5) });
            stackPanel.Children.Add(new Button() { Content = "This is a button with different color.", BorderBrush = Brushes.Orange, Background = Brushes.Yellow, Foreground = Brushes.OrangeRed, Width = 250, Height = 30, VerticalContentAlignment = VerticalAlignment.Center, Margin = new Thickness(10, 5, 10, 5) });
            stackPanel.Children.Add(new TextBox() { Text = "This is a textbox, but you can't type text in FixedDocument.", Margin = new Thickness(10, 5, 10, 5), Width = 550, Height = 30, VerticalContentAlignment = VerticalAlignment.Center });

            FixedPage.SetTop(stackPanel, 60); //Top margin
            FixedPage.SetLeft(stackPanel, 60); //Left margin

            return stackPanel;
        }

        private List<PageContent> ReloadDocumentMethod(PrintLabel.PrintDialog.DocumentInfo documentInfo)
        {
          
            List<PageContent> pages = new List<PageContent>();

            for (int i = 0; i < 5; i++)
            {
                Size pageSize = PrintLabel.PaperHelper.PaperHelper.GetPaperSize(System.Printing.PageMediaSizeName.ISOA4, true);

                FixedPage fixedPage = new FixedPage()
                {
                    Width = pageSize.Width,
                    Height = pageSize.Height
                };

                StackPanel stackPanel = CreateContent(pageSize.Width, pageSize.Height, documentInfo.Margin.Value);

                fixedPage.Children.Add(stackPanel);
                pages.Add(new PageContent() { Child = fixedPage });
            }

            return pages;
        }


        internal void BeginSettingAndPreviewing(FixedDocument document, string documentName, double pageMargin, PrintDialog.PrintDialogSettings defaultSettings, bool allowPagesOption, bool allowScaleOption, bool allowTwoSidedOption, bool allowPagesPerSheetOption, bool allowPageOrderOption, bool allowMoreSettingsExpander, bool allowAddNewPrinerComboBoxItem, bool allowPrinterPreferencesButton, Func<PrintDialog.DocumentInfo, List<PageContent>> getDocumentWhenReloadDocumentMethod)
        {
            printPage = new PrintPage(document, documentName, pageMargin, defaultSettings, allowPagesOption, allowScaleOption, allowTwoSidedOption, allowPagesPerSheetOption, allowPageOrderOption, allowMoreSettingsExpander, allowAddNewPrinerComboBoxItem, allowPrinterPreferencesButton, getDocumentWhenReloadDocumentMethod);

            mainFrame.Navigate(printPage);

            if (mainFrame.CanGoBack)
            {
                mainFrame.RemoveBackEntry();
            }
        }
    }

}
