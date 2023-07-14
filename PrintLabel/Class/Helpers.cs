using System;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Printing;
using System.Reflection;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Markup;
using System.Windows.Controls;
using System.Windows.Documents;

namespace PrintLabel.PrintDialog
{

    public class PrintDialogSettings
    {
        /// <summary>
        /// Initialize a <see cref="PrintDialogSettings"/> class.
        /// </summary>
        public PrintDialogSettings()
        {
            UsePrinterDefaultSettings = false;
            Layout = PrintSettings.PageOrientation.Portrait;
            Color = PrintSettings.PageColor.Color;
            Quality = PrintSettings.PageQuality.Normal;
            PageSize = PrintSettings.PageSize.ISOA4;
            PageType = PrintSettings.PageType.Plain;
            TwoSided = PrintSettings.TwoSided.OneSided;
            PagesPerSheet = 1;
            PageOrder = PrintSettings.PageOrder.Horizontal;
        }

        /// <summary>
        /// Use printer default settings or not.
        /// </summary>
        public bool UsePrinterDefaultSettings { get; internal set; } = false;

        /// <summary>
        /// Layout.
        /// </summary>
        public PrintSettings.PageOrientation Layout { get; set; } = PrintSettings.PageOrientation.Portrait;

        /// <summary>
        /// Color.
        /// </summary>
        public PrintSettings.PageColor Color { get; set; } = PrintSettings.PageColor.Color;

        /// <summary>
        /// Quality.
        /// </summary>
        public PrintSettings.PageQuality Quality { get; set; } = PrintSettings.PageQuality.Normal;

        /// <summary>
        /// Page size.
        /// </summary>
        public PrintSettings.PageSize PageSize { get; set; } = PrintSettings.PageSize.ISOA4;

        /// <summary>
        /// Page type.
        /// </summary>
        public PrintSettings.PageType PageType { get; set; } = PrintSettings.PageType.Plain;

        /// <summary>
        /// Two-sided.
        /// </summary>
        public PrintSettings.TwoSided TwoSided { get; set; } = PrintSettings.TwoSided.OneSided;

        /// <summary>
        /// Pages per sheet.
        /// </summary>
        public int PagesPerSheet { get; set; } = 1;

        /// <summary>
        /// Page order.
        /// </summary>
        public PrintSettings.PageOrder PageOrder { get; set; } = PrintSettings.PageOrder.Horizontal;

        /// <summary>
        /// Initialize a <see cref="PrintDialogSettings"/> that use printer default settings
        /// </summary>
        /// <returns>The <see cref="PrintDialogSettings"/> that use printer default settings.</returns>
        public static PrintDialogSettings PrinterDefaultSettings()
        {
            return new PrintDialogSettings()
            {
                UsePrinterDefaultSettings = true
            };
        }

        /// <summary>
        /// Change <see cref="PrintDialogSettings"/> property value.
        /// </summary>
        /// <param name="propertyName">The property name.</param>
        /// <param name="propertyValue">The value will change to.</param>
        /// <returns>The <see cref="PrintDialogSettings"/> after change.</returns>
        public PrintDialogSettings ChangePropertyValue(string propertyName, object propertyValue)
        {
            PropertyInfo property = this.GetType().GetProperty(propertyName, BindingFlags.Instance);

            if (property == null)
            {
                if (this.GetType().GetProperty(propertyName, BindingFlags.NonPublic) != null)
                {
                    throw new Exception("Can't change private, protected or internal property.");
                }

                throw new Exception("Can't find property. Please make sure the property name is correct.");
            }
            else
            {
                try
                {
                    property.SetValue(this, propertyValue);
                }
                catch
                {
                    throw new Exception("Can't change property's value.");
                }
            }

            return this;
        }
    }


    public class DocumentInfo
    {
        /// <summary>
        /// Initialize a <see cref="DocumentInfo"/> class.
        /// </summary>
        public DocumentInfo()
        {
            Scale = null;
            Size = null;
            Margin = null;
            Pages = null;
            PagesPerSheet = null;
            Color = null;
            PageOrder = null;
            Orientation = null;
        }

        /// <summary>
        /// Page size which not calculate with orientation.
        /// </summary>
        public Size? Size { get; internal set; } = null;

        /// <summary>
        /// Pages that need to display. The array include each page count.
        /// </summary>
        public int[] Pages { get; internal set; } = null;

        /// <summary>
        /// Page scale, a percentage value, except <see cref="Double.NaN"/> means auto fit.
        /// </summary>
        public double? Scale { get; internal set; } = null;

        /// <summary>
        /// Page margin.
        /// </summary>
        public double? Margin { get; internal set; } = null;

        /// <summary>
        /// Pages per sheet.
        /// </summary>
        public int? PagesPerSheet { get; internal set; } = null;

        /// <summary>
        /// Color.
        /// </summary>
        public PrintSettings.PageColor? Color { get; internal set; } = null;

        /// <summary>
        /// Page order.
        /// </summary>
        public PrintSettings.PageOrder? PageOrder { get; internal set; } = null;

        /// <summary>
        /// Page orientation.
        /// </summary>
        public PrintSettings.PageOrientation? Orientation { get; internal set; } = null;
    }


    public class PrintDialog
    {
       
        public PrintDialog()
        {
            Owner = null;
            Title = "Print";
            Icon = null;
            Topmost = false;
            ShowInTaskbar = false;
            AllowScaleOption = true;
            AllowPagesOption = true;
            AllowTwoSidedOption = true;
            AllowPageOrderOption = true;
            AllowPagesPerSheetOption = true;
            AllowAddNewPrinterButton = true;
            AllowMoreSettingsExpander = true;
            AllowPrinterPreferencesButton = true;
            Document = null;
            DocumentMargin = 0;
            DocumentName = "Untitled Document";
            ResizeMode = ResizeMode.NoResize;
            DefaultSettings = new PrintDialogSettings();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            CustomReloadDocumentMethod = null;
        }

        /// <summary>
        /// <see cref="PrintDialog"/>'s owner.
        /// </summary>
        public Window Owner { get; set; } = null;

        /// <summary>
        /// <see cref="PrintDialog"/>'s title.
        /// </summary>
        public string Title { get; set; } = "Print";

        /// <summary>
        /// <see cref="PrintDialog"/>'s icon. Null means use default icon.
        /// </summary>
        public ImageSource Icon { get; set; } = null;

        /// <summary>
        /// The document margin info.
        /// </summary>
        public double DocumentMargin { get; set; } = 0;

        /// <summary>
        /// Allow <see cref="PrintDialog"/> at top most or not.
        /// </summary>
        public bool Topmost { get; set; } = false;

        /// <summary>
        /// Alllow <see cref="PrintDialog"/> show in taskbar or not.
        /// </summary>
        public bool ShowInTaskbar { get; set; } = false;

        /// <summary>
        /// Allow scale option or not.
        /// </summary>
        public bool AllowScaleOption { get; set; } = true;

        /// <summary>
        /// Allow pages option (contains "All Pages", "Current Page", and "Custom Pages") or not.
        /// </summary>
        public bool AllowPagesOption { get; set; } = true;

        /// <summary>
        /// Allow two-sided option or not.
        /// </summary>
        public bool AllowTwoSidedOption { get; set; } = true;

        /// <summary>
        /// Allow page order option or not if allow pages per sheet option.
        /// </summary>
        public bool AllowPageOrderOption { get; set; } = true;

        /// <summary>
        /// Allow pages per sheet option or not.
        /// </summary>
        public bool AllowPagesPerSheetOption { get; set; } = true;

        /// <summary>
        /// Allow add new printer button in printer list or not.
        /// </summary>
        public bool AllowAddNewPrinterButton { get; set; } = true;

        /// <summary>
        /// Allow more settings expander or just show all settings.
        /// </summary>
        public bool AllowMoreSettingsExpander { get; set; } = true;

        /// <summary>
        /// Allow printer preferences button or not.
        /// </summary>
        public bool AllowPrinterPreferencesButton { get; set; } = true;

        /// <summary>
        /// The document that need to print.
        /// </summary>
        public FixedDocument Document { get; set; } = null;

        /// <summary>
        /// The document name that will display in print list.
        /// </summary>
        public string DocumentName { get; set; } = "Untitled Document";

        /// <summary>
        /// <see cref="PrintDialog"/>'s resize mode.
        /// </summary>
        public ResizeMode ResizeMode { get; set; } = ResizeMode.NoResize;

        /// <summary>
        /// The default settings.
        /// </summary>
        public PrintDialogSettings DefaultSettings { get; set; } = new PrintDialogSettings();

        /// <summary>
        /// <see cref="PrintDialog"/>'s startup location.
        /// </summary>
        public WindowStartupLocation WindowStartupLocation { get; set; } = WindowStartupLocation.CenterScreen;

        /// <summary>
        /// The method that will use to get document when reload document. You can only change the content in the document. The method must return a list of <see cref="PageContent"/> that represents the page content in order.
        /// </summary>
        public Func<DocumentInfo, List<PageContent>> CustomReloadDocumentMethod { get; set; } = null;


        public void LoadingEnd(MainWindow window)
        {

            window.BeginSettingAndPreviewing(Document, DocumentName, DocumentMargin, DefaultSettings, AllowPagesOption, AllowScaleOption, AllowTwoSidedOption, AllowPagesPerSheetOption, AllowPageOrderOption, AllowMoreSettingsExpander, AllowAddNewPrinterButton, AllowPrinterPreferencesButton, CustomReloadDocumentMethod);
            
        }
    }


}
