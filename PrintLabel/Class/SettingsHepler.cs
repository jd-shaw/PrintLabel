using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace PrintLabel.SettingsHepler
{
    public class NameInfoHepler
    {

        protected NameInfoHepler()
        {
            return;
        }

        public static string GetPageMediaSizeNameInfo(PageMediaSizeName sizeName)
        {
            switch (sizeName)
            {
                case PageMediaSizeName.BusinessCard: return "Business Card";
                case
                PageMediaSizeName.CreditCard:
                    return "Credit Card";
                case
                PageMediaSizeName.ISOA0:
                    return "ISO A0";
                case
                PageMediaSizeName.ISOA1:
                    return "ISO A1";
                case
                PageMediaSizeName.ISOA10:
                    return "ISO A10";
                case
                PageMediaSizeName.ISOA2:
                    return "ISO A2";
                case
                PageMediaSizeName.ISOA3:
                    return "ISO A3";
                case
                PageMediaSizeName.ISOA3Extra:
                    return "ISO A3 Extra";
                case
                PageMediaSizeName.ISOA3Rotated:
                    return "ISO A3 Rotated";
                case
                PageMediaSizeName.ISOA4:
                    return "ISO A4";
                case
                PageMediaSizeName.ISOA4Extra:
                    return "ISO A4 Extra";
                case
                PageMediaSizeName.ISOA4Rotated:
                    return "ISO A4 Rotated";
                case
                PageMediaSizeName.ISOA5:
                    return "ISO A5";
                case
                PageMediaSizeName.ISOA5Extra:
                    return "ISO A5 Extra";
                case
                PageMediaSizeName.ISOA5Rotated:
                    return "ISO A5 Rotated";
                case
                PageMediaSizeName.ISOA6:
                    return "ISO A6";
                case
                PageMediaSizeName.ISOA6Rotated:
                    return "ISO A6 Rotated";
                case
                PageMediaSizeName.ISOA7:
                    return "ISO A7";
                case
                PageMediaSizeName.ISOA8:
                    return "ISO A8";
                case
                PageMediaSizeName.ISOA9:
                    return "ISO A9";
                case
                PageMediaSizeName.ISOB0:
                    return "ISO B0";
                case
                PageMediaSizeName.ISOB1:
                    return "ISO B1";
                case
                PageMediaSizeName.ISOB10:
                    return "ISO B10";
                case
                PageMediaSizeName.ISOB2:
                    return "ISO B2";
                case
                PageMediaSizeName.ISOB3:
                    return "ISO B3";
                case
                PageMediaSizeName.ISOB4:
                    return "ISO B4";
                case
                PageMediaSizeName.ISOB4Envelope:
                    return "ISO B4 Envelope";
                case
                PageMediaSizeName.ISOB5Envelope:
                    return "ISO B5 Envelope";
                case
                PageMediaSizeName.ISOB5Extra:
                    return "ISO B5 Extra";
                case
                PageMediaSizeName.ISOB7:
                    return "ISO B7";
                case
                PageMediaSizeName.ISOB8:
                    return "ISO B8";
                case
                PageMediaSizeName.ISOB9:
                    return "ISO B9";
                case
                PageMediaSizeName.ISOC0:
                    return "ISO C0";
                case
                PageMediaSizeName.ISOC1:
                    return "ISO C1";
                case
                PageMediaSizeName.ISOC2:
                    return "ISO C2";
                case
                PageMediaSizeName.ISOC3:
                    return "ISO C3";
                case
                PageMediaSizeName.ISOC3Envelope:
                    return "ISO C3 Envelope";
                case
                PageMediaSizeName.ISOC4:
                    return "ISO C4";
                case
                PageMediaSizeName.ISOC4Envelope:
                    return "ISO C4 Envelope";
                case
                PageMediaSizeName.ISOC5:
                    return "ISO C5";
                case
                PageMediaSizeName.ISOC5Envelope:
                    return "ISO C5 Envelope";
                case
                PageMediaSizeName.ISOC6:
                    return "ISO C6";
                case
                PageMediaSizeName.ISOC6C5Envelope:
                    return "ISO C6C5 Envelope";
                case
                PageMediaSizeName.ISOC6Envelope:
                    return "ISO C6 Envelope";
                case
                PageMediaSizeName.ISOC7:
                    return "ISO C7";
                case
                PageMediaSizeName.ISOC8:
                    return "ISO C8";
                case
                PageMediaSizeName.ISOC9:
                    return "ISO C9";
                case
                PageMediaSizeName.ISOC10:
                    return "ISO C10";
                case
                PageMediaSizeName.ISODLEnvelope:
                    return "ISO DL Envelope";
                case
                PageMediaSizeName.ISODLEnvelopeRotated:
                    return "ISO DL Envelope Rotated";
                case
                PageMediaSizeName.ISOSRA3:
                    return "ISO SRA3";
                case
                PageMediaSizeName.Japan2LPhoto:
                    return "Japan 2L Photo";
                case
                PageMediaSizeName.JapanChou3Envelope:
                    return "Japan Chou 3 Envelope";
                case
                PageMediaSizeName.JapanChou3EnvelopeRotated:
                    return "Japan Chou 3 Envelope Rotated";
                case
                PageMediaSizeName.JapanChou4Envelope:
                    return "Japan Chou 4 Envelope";
                case
                PageMediaSizeName.JapanChou4EnvelopeRotated:
                    return "Japan Chou 4 Envelope Rotated";
                case
                PageMediaSizeName.JapanDoubleHagakiPostcard:
                    return "Japan Double Hagaki Postcard";
                case
                PageMediaSizeName.JapanDoubleHagakiPostcardRotated:
                    return "Japan Double Hagaki Postcard Rotated";
                case
                PageMediaSizeName.JapanHagakiPostcard:
                    return "Japan Hagaki Postcard";
                case
                PageMediaSizeName.JapanHagakiPostcardRotated:
                    return "Japan Hagaki Postcard Rotated";
                case
                PageMediaSizeName.JapanKaku2Envelope:
                    return "Japan Kaku 2 Envelope";
                case
                PageMediaSizeName.JapanKaku2EnvelopeRotated:
                    return "Japan Kaku 2 Envelope Rotated";
                case
                PageMediaSizeName.JapanKaku3Envelope:
                    return "Japan Kaku 3 Envelope";
                case
                PageMediaSizeName.JapanKaku3EnvelopeRotated:
                    return "Japan Kaku 3 Envelope Rotated";
                case
                PageMediaSizeName.JapanLPhoto:
                    return "Japan L Photo";
                case
                PageMediaSizeName.JapanQuadrupleHagakiPostcard:
                    return "Japan Quadruple Hagaki Postcard";
                case
                PageMediaSizeName.JapanYou1Envelope:
                    return "Japan You 1 Envelope";
                case
                PageMediaSizeName.JapanYou2Envelope:
                    return "Japan You 2 Envelope";
                case
                PageMediaSizeName.JapanYou3Envelope:
                    return "Japan You 3 Envelope";
                case
                PageMediaSizeName.JapanYou4Envelope:
                    return "Japan You 4 Envelope";
                case
                PageMediaSizeName.JapanYou4EnvelopeRotated:
                    return "Japan You 4 Envelope Rotated";
                case
                PageMediaSizeName.JapanYou6Envelope:
                    return "Japan You 6 Envelope";
                case
                PageMediaSizeName.JapanYou6EnvelopeRotated:
                    return "Japan You 6 Envelope Rotated";
                case
                PageMediaSizeName.JISB0:
                    return "JIS B0";
                case
                PageMediaSizeName.JISB1:
                    return "JIS B1";
                case
                PageMediaSizeName.JISB10:
                    return "JIS B10";
                case
                PageMediaSizeName.JISB2:
                    return "JIS B2";
                case
                PageMediaSizeName.JISB3:
                    return "JIS B3";
                case
                PageMediaSizeName.JISB4:
                    return "JIS B4";
                case
                PageMediaSizeName.JISB4Rotated:
                    return "JIS B4 Rotated";
                case
                PageMediaSizeName.JISB5:
                    return "JIS B5";
                case
                PageMediaSizeName.JISB5Rotated:
                    return "JIS B5 Rotated";
                case
                PageMediaSizeName.JISB6:
                    return "JIS B6";
                case
                PageMediaSizeName.JISB6Rotated:
                    return "JIS B6 Rotated";
                case
                PageMediaSizeName.JISB7:
                    return "JIS B7";
                case
                PageMediaSizeName.JISB8:
                    return "JIS B8";
                case
                PageMediaSizeName.JISB9:
                    return "JIS B9";
                case
                PageMediaSizeName.NorthAmerica10x11:
                    return "North America 10 x 11";
                case
                PageMediaSizeName.NorthAmerica10x12:
                    return "North America 10 x 12";
                case
                PageMediaSizeName.NorthAmerica10x14:
                    return "North America 10 x 14";
                case
                PageMediaSizeName.NorthAmerica11x17:
                    return "North America 11 x 17";
                case
                PageMediaSizeName.NorthAmerica14x17:
                    return "North America 14 x 17";
                case
                PageMediaSizeName.NorthAmerica4x6:
                    return "North America 4 x 6";
                case
                PageMediaSizeName.NorthAmerica4x8:
                    return "North America 4 x 8";
                case
                PageMediaSizeName.NorthAmerica5x7:
                    return "North America 5 x 7";
                case
                PageMediaSizeName.NorthAmerica8x10:
                    return "North America 8 x 10";
                case
                PageMediaSizeName.NorthAmerica9x11:
                    return "North America 9 x 11";
                case
                PageMediaSizeName.NorthAmericaArchitectureASheet:
                    return "North America Architecture A Sheet";
                case
                PageMediaSizeName.NorthAmericaArchitectureBSheet:
                    return "North America Architecture B Sheet";
                case
                PageMediaSizeName.NorthAmericaArchitectureCSheet:
                    return "North America Architecture C Sheet";
                case
                PageMediaSizeName.NorthAmericaArchitectureDSheet:
                    return "North America Architecture D Sheet";
                case
                PageMediaSizeName.NorthAmericaArchitectureESheet:
                    return "North America Architecture E Sheet";
                case
                PageMediaSizeName.NorthAmericaCSheet:
                    return "North America C Sheet";
                case
                PageMediaSizeName.NorthAmericaDSheet:
                    return "North America D Sheet";
                case
                PageMediaSizeName.NorthAmericaESheet:
                    return "North America E Sheet";
                case
                PageMediaSizeName.NorthAmericaExecutive:
                    return "North America Executive";
                case
                PageMediaSizeName.NorthAmericaGermanLegalFanfold:
                    return "North America German Legal Fanfold";
                case
                PageMediaSizeName.NorthAmericaGermanStandardFanfold:
                    return "North America German Standard Fanfold";
                case
                PageMediaSizeName.NorthAmericaLegal:
                    return "North America Legal";
                case
                PageMediaSizeName.NorthAmericaLegalExtra:
                    return "North America Legal Extra";
                case
                PageMediaSizeName.NorthAmericaLetter:
                    return "North America Letter";
                case
                PageMediaSizeName.NorthAmericaLetterExtra:
                    return "North America Letter Extra";
                case
                PageMediaSizeName.NorthAmericaLetterPlus:
                    return "North America Letter Plus";
                case
                PageMediaSizeName.NorthAmericaLetterRotated:
                    return "North America Letter Rotated";
                case
                PageMediaSizeName.NorthAmericaMonarchEnvelope:
                    return "North America Monarch Envelope";
                case
                PageMediaSizeName.NorthAmericaNote:
                    return "North America Note";
                case
                PageMediaSizeName.NorthAmericaNumber10Envelope:
                    return "North America Number 10 Envelope";
                case
                PageMediaSizeName.NorthAmericaNumber10EnvelopeRotated:
                    return "North America Number 10 Envelope Rotated";
                case
                PageMediaSizeName.NorthAmericaNumber11Envelope:
                    return "North America Number 11 Envelope";
                case
                PageMediaSizeName.NorthAmericaNumber12Envelope:
                    return "North America Number 12 Envelope";
                case
                PageMediaSizeName.NorthAmericaNumber14Envelope:
                    return "North America Number 14 Envelope";
                case
                PageMediaSizeName.NorthAmericaNumber9Envelope:
                    return "North America Number 9 Envelope";
                case
                PageMediaSizeName.NorthAmericaPersonalEnvelope:
                    return "North America Personal Envelope";
                case
                PageMediaSizeName.NorthAmericaQuarto:
                    return "North America Quarto";
                case
                PageMediaSizeName.NorthAmericaStatement:
                    return "North America Statement";
                case
                PageMediaSizeName.NorthAmericaSuperA:
                    return "North America Super A";
                case
                PageMediaSizeName.NorthAmericaSuperB:
                    return "North America Super B";
                case
                PageMediaSizeName.NorthAmericaTabloid:
                    return "North America Tabloid";
                case
                PageMediaSizeName.NorthAmericaTabloidExtra:
                    return "North America Tabloid Extra";
                case
                PageMediaSizeName.OtherMetricA3Plus:
                    return "A3 Plus";
                case
                PageMediaSizeName.OtherMetricA4Plus:
                    return "A4 Plus";
                case
                PageMediaSizeName.OtherMetricFolio:
                    return "Folio";
                case
                PageMediaSizeName.OtherMetricInviteEnvelope:
                    return "Invite Envelope";
                case
                PageMediaSizeName.OtherMetricItalianEnvelope:
                    return "Italian Envelope";
                case
                PageMediaSizeName.PRC10Envelope:
                    return "PRC #10 Envelope";
                case
                PageMediaSizeName.PRC10EnvelopeRotated:
                    return "PRC #10 Envelope Rotated";
                case
                PageMediaSizeName.PRC16K:
                    return "PRC 16K";
                case
                PageMediaSizeName.PRC16KRotated:
                    return "PRC 16K Rotated";
                case
                PageMediaSizeName.PRC1Envelope:
                    return "PRC #1 Envelope";
                case
                PageMediaSizeName.PRC1EnvelopeRotated:
                    return "PRC #1 Envelope Rotated";
                case
                PageMediaSizeName.PRC2Envelope:
                    return "PRC #2 Envelope";
                case
                PageMediaSizeName.PRC2EnvelopeRotated:
                    return "PRC #2 Envelope Rotated";
                case
                PageMediaSizeName.PRC32K:
                    return "PRC 32K";
                case
                PageMediaSizeName.PRC32KBig:
                    return "PRC 32K Big";
                case
                PageMediaSizeName.PRC32KRotated:
                    return "PRC 32K Rotated";
                case
                PageMediaSizeName.PRC3Envelope:
                    return "PRC #3 Envelope";
                case
                PageMediaSizeName.PRC3EnvelopeRotated:
                    return "PRC #3 Envelope Rotated";
                case
                PageMediaSizeName.PRC4Envelope:
                    return "PRC #4 Envelope";
                case
                PageMediaSizeName.PRC4EnvelopeRotated:
                    return "PRC #4 Envelope Rotated";
                case
                PageMediaSizeName.PRC5Envelope:
                    return "PRC #5 Envelope";
                case
                PageMediaSizeName.PRC5EnvelopeRotated:
                    return "PRC #5 Envelope Rotated";
                case
                PageMediaSizeName.PRC6Envelope:
                    return "PRC #6 Envelope";
                case
                PageMediaSizeName.PRC6EnvelopeRotated:
                    return "PRC #6 Envelope Rotated";
                case
                PageMediaSizeName.PRC7Envelope:
                    return "PRC #7 Envelope";
                case
                PageMediaSizeName.PRC7EnvelopeRotated:
                    return "PRC #7 Envelope Rotated";
                case
                PageMediaSizeName.PRC8Envelope:
                    return "PRC #8 Envelope";
                case
                PageMediaSizeName.PRC8EnvelopeRotated:
                    return "PRC #8 Envelope Rotated";
                case
                PageMediaSizeName.PRC9Envelope:
                    return "PRC #9 Envelope";
                case
                PageMediaSizeName.PRC9EnvelopeRotated:
                    return "PRC #9 Envelope Rotated";
                case
                PageMediaSizeName.Roll04Inch:
                    return "4-inch Wide Roll";
                case
                PageMediaSizeName.Roll06Inch:
                    return "6-inch Wide Roll";
                case
                PageMediaSizeName.Roll08Inch:
                    return "8-inch Wide Roll";
                case
                PageMediaSizeName.Roll12Inch:
                    return "12-inch Wide Roll";
                case
                PageMediaSizeName.Roll15Inch:
                    return "15-inch Wide Roll";
                case
                PageMediaSizeName.Roll18Inch:
                    return "18-inch Wide Roll";
                case
                PageMediaSizeName.Roll22Inch:
                    return "22-inch Wide Roll";
                case
                PageMediaSizeName.Roll24Inch:
                    return "24-inch Wide Roll";
                case
                PageMediaSizeName.Roll30Inch:
                    return "30-inch Wide Roll";
                case
                PageMediaSizeName.Roll36Inch:
                    return "36-inch Wide Roll";
                case
                PageMediaSizeName.Roll54Inch:
                    return "54-inch Wide Roll";
                default:
                    return "Unknown Size";

            }
        }

        public static string GetPageMediaSizeNameInfo(PrintSettings.PageSize sizeName)
        {
            switch (sizeName)
            {
                case PrintSettings.PageSize.BusinessCard: return "Business Card";
                case
                PrintSettings.PageSize.CreditCard:
                    return "Credit Card";
                case
                PrintSettings.PageSize.ISOA0:
                    return "ISO A0";
                case
                PrintSettings.PageSize.ISOA1:
                    return "ISO A1";
                case
                PrintSettings.PageSize.ISOA10:
                    return "ISO A10";
                case
                PrintSettings.PageSize.ISOA2:
                    return "ISO A2";
                case
                PrintSettings.PageSize.ISOA3:
                    return "ISO A3";
                case
                PrintSettings.PageSize.ISOA3Extra:
                    return "ISO A3 Extra";
                case
                PrintSettings.PageSize.ISOA3Rotated:
                    return "ISO A3 Rotated";
                case
                PrintSettings.PageSize.ISOA4:
                    return "ISO A4";
                case
                PrintSettings.PageSize.ISOA4Extra:
                    return "ISO A4 Extra";
                case
                PrintSettings.PageSize.ISOA4Rotated:
                    return "ISO A4 Rotated";
                case
                PrintSettings.PageSize.ISOA5:
                    return "ISO A5";
                case
                PrintSettings.PageSize.ISOA5Extra:
                    return "ISO A5 Extra";
                case
                PrintSettings.PageSize.ISOA5Rotated:
                    return "ISO A5 Rotated";
                case
                PrintSettings.PageSize.ISOA6:
                    return "ISO A6";
                case
                PrintSettings.PageSize.ISOA6Rotated:
                    return "ISO A6 Rotated";
                case
                PrintSettings.PageSize.ISOA7:
                    return "ISO A7";
                case
                PrintSettings.PageSize.ISOA8:
                    return "ISO A8";
                case
                PrintSettings.PageSize.ISOA9:
                    return "ISO A9";
                case
                PrintSettings.PageSize.ISOB0:
                    return "ISO B0";
                case
                PrintSettings.PageSize.ISOB1:
                    return "ISO B1";
                case
                PrintSettings.PageSize.ISOB10:
                    return "ISO B10";
                case
                PrintSettings.PageSize.ISOB2:
                    return "ISO B2";
                case
                PrintSettings.PageSize.ISOB3:
                    return "ISO B3";
                case
                PrintSettings.PageSize.ISOB4:
                    return "ISO B4";
                case
                PrintSettings.PageSize.ISOB4Envelope:
                    return "ISO B4 Envelope";
                case
                PrintSettings.PageSize.ISOB5Envelope:
                    return "ISO B5 Envelope";
                case
                PrintSettings.PageSize.ISOB5Extra:
                    return "ISO B5 Extra";
                case
                PrintSettings.PageSize.ISOB7:
                    return "ISO B7";
                case
                PrintSettings.PageSize.ISOB8:
                    return "ISO B8";
                case
                PrintSettings.PageSize.ISOB9:
                    return "ISO B9";
                case
                PrintSettings.PageSize.ISOC0:
                    return "ISO C0";
                case
                PrintSettings.PageSize.ISOC1:
                    return "ISO C1";
                case
                PrintSettings.PageSize.ISOC2:
                    return "ISO C2";
                case
                PrintSettings.PageSize.ISOC3:
                    return "ISO C3";
                case
                PrintSettings.PageSize.ISOC3Envelope:
                    return "ISO C3 Envelope";
                case
                PrintSettings.PageSize.ISOC4:
                    return "ISO C4";
                case
                PrintSettings.PageSize.ISOC4Envelope:
                    return "ISO C4 Envelope";
                case
                PrintSettings.PageSize.ISOC5:
                    return "ISO C5";
                case
                PrintSettings.PageSize.ISOC5Envelope:
                    return "ISO C5 Envelope";
                case
                PrintSettings.PageSize.ISOC6:
                    return "ISO C6";
                case
                PrintSettings.PageSize.ISOC6C5Envelope:
                    return "ISO C6C5 Envelope";
                case
                PrintSettings.PageSize.ISOC6Envelope:
                    return "ISO C6 Envelope";
                case
                PrintSettings.PageSize.ISOC7:
                    return "ISO C7";
                case
                PrintSettings.PageSize.ISOC8:
                    return "ISO C8";
                case
                PrintSettings.PageSize.ISOC9:
                    return "ISO C9";
                case
                PrintSettings.PageSize.ISOC10:
                    return "ISO C10";
                case
                PrintSettings.PageSize.ISODLEnvelope:
                    return "ISO DL Envelope";
                case
                PrintSettings.PageSize.ISODLEnvelopeRotated:
                    return "ISO DL Envelope Rotated";
                case
                PrintSettings.PageSize.ISOSRA3:
                    return "ISO SRA3";
                case
                PrintSettings.PageSize.Japan2LPhoto:
                    return "Japan 2L Photo";
                case
                PrintSettings.PageSize.JapanChou3Envelope:
                    return "Japan Chou 3 Envelope";
                case
                PrintSettings.PageSize.JapanChou3EnvelopeRotated:
                    return "Japan Chou 3 Envelope Rotated";
                case
                PrintSettings.PageSize.JapanChou4Envelope:
                    return "Japan Chou 4 Envelope";
                case
                PrintSettings.PageSize.JapanChou4EnvelopeRotated:
                    return "Japan Chou 4 Envelope Rotated";
                case
                PrintSettings.PageSize.JapanDoubleHagakiPostcard:
                    return "Japan Double Hagaki Postcard";
                case
                PrintSettings.PageSize.JapanDoubleHagakiPostcardRotated:
                    return "Japan Double Hagaki Postcard Rotated";
                case
                PrintSettings.PageSize.JapanHagakiPostcard:
                    return "Japan Hagaki Postcard";
                case
                PrintSettings.PageSize.JapanHagakiPostcardRotated:
                    return "Japan Hagaki Postcard Rotated";
                case
                PrintSettings.PageSize.JapanKaku2Envelope:
                    return "Japan Kaku 2 Envelope";
                case
                PrintSettings.PageSize.JapanKaku2EnvelopeRotated:
                    return "Japan Kaku 2 Envelope Rotated";
                case
                PrintSettings.PageSize.JapanKaku3Envelope:
                    return "Japan Kaku 3 Envelope";
                case
                PrintSettings.PageSize.JapanKaku3EnvelopeRotated:
                    return "Japan Kaku 3 Envelope Rotated";
                case
                PrintSettings.PageSize.JapanLPhoto:
                    return "Japan L Photo";
                case
                PrintSettings.PageSize.JapanQuadrupleHagakiPostcard:
                    return "Japan Quadruple Hagaki Postcard";
                case
                PrintSettings.PageSize.JapanYou1Envelope:
                    return "Japan You 1 Envelope";
                case
                PrintSettings.PageSize.JapanYou2Envelope:
                    return "Japan You 2 Envelope";
                case
                PrintSettings.PageSize.JapanYou3Envelope:
                    return "Japan You 3 Envelope";
                case
                PrintSettings.PageSize.JapanYou4Envelope:
                    return "Japan You 4 Envelope";
                case
                PrintSettings.PageSize.JapanYou4EnvelopeRotated:
                    return "Japan You 4 Envelope Rotated";
                case
                PrintSettings.PageSize.JapanYou6Envelope:
                    return "Japan You 6 Envelope";
                case
                PrintSettings.PageSize.JapanYou6EnvelopeRotated:
                    return "Japan You 6 Envelope Rotated";
                case
                PrintSettings.PageSize.JISB0:
                    return "JIS B0";
                case
                PrintSettings.PageSize.JISB1:
                    return "JIS B1";
                case
                PrintSettings.PageSize.JISB10:
                    return "JIS B10";
                case
                PrintSettings.PageSize.JISB2:
                    return "JIS B2";
                case
                PrintSettings.PageSize.JISB3:
                    return "JIS B3";
                case
                PrintSettings.PageSize.JISB4:
                    return "JIS B4";
                case
                PrintSettings.PageSize.JISB4Rotated:
                    return "JIS B4 Rotated";
                case
                PrintSettings.PageSize.JISB5:
                    return "JIS B5";
                case
                PrintSettings.PageSize.JISB5Rotated:
                    return "JIS B5 Rotated";
                case
                PrintSettings.PageSize.JISB6:
                    return "JIS B6";
                case
                PrintSettings.PageSize.JISB6Rotated:
                    return "JIS B6 Rotated";
                case
                PrintSettings.PageSize.JISB7:
                    return "JIS B7";
                case
                PrintSettings.PageSize.JISB8:
                    return "JIS B8";
                case
                PrintSettings.PageSize.JISB9:
                    return "JIS B9";
                case
                PrintSettings.PageSize.NorthAmerica10x11:
                    return "North America 10 x 11";
                case
                PrintSettings.PageSize.NorthAmerica10x12:
                    return "North America 10 x 12";
                case
                PrintSettings.PageSize.NorthAmerica10x14:
                    return "North America 10 x 14";
                case
                PrintSettings.PageSize.NorthAmerica11x17:
                    return "North America 11 x 17";
                case
                PrintSettings.PageSize.NorthAmerica14x17:
                    return "North America 14 x 17";
                case
                PrintSettings.PageSize.NorthAmerica4x6:
                    return "North America 4 x 6";
                case
                PrintSettings.PageSize.NorthAmerica4x8:
                    return "North America 4 x 8";
                case
                PrintSettings.PageSize.NorthAmerica5x7:
                    return "North America 5 x 7";
                case
                PrintSettings.PageSize.NorthAmerica8x10:
                    return "North America 8 x 10";
                case
                PrintSettings.PageSize.NorthAmerica9x11:
                    return "North America 9 x 11";
                case
                PrintSettings.PageSize.NorthAmericaArchitectureASheet:
                    return "North America Architecture A Sheet";
                case
                PrintSettings.PageSize.NorthAmericaArchitectureBSheet:
                    return "North America Architecture B Sheet";
                case
                PrintSettings.PageSize.NorthAmericaArchitectureCSheet:
                    return "North America Architecture C Sheet";
                case
                PrintSettings.PageSize.NorthAmericaArchitectureDSheet:
                    return "North America Architecture D Sheet";
                case
                PrintSettings.PageSize.NorthAmericaArchitectureESheet:
                    return "North America Architecture E Sheet";
                case
                PrintSettings.PageSize.NorthAmericaCSheet:
                    return "North America C Sheet";
                case
                PrintSettings.PageSize.NorthAmericaDSheet:
                    return "North America D Sheet";
                case
                PrintSettings.PageSize.NorthAmericaESheet:
                    return "North America E Sheet";
                case
                PrintSettings.PageSize.NorthAmericaExecutive:
                    return "North America Executive";
                case
                PrintSettings.PageSize.NorthAmericaGermanLegalFanfold:
                    return "North America German Legal Fanfold";
                case
                PrintSettings.PageSize.NorthAmericaGermanStandardFanfold:
                    return "North America German Standard Fanfold";
                case
                PrintSettings.PageSize.NorthAmericaLegal:
                    return "North America Legal";
                case
                PrintSettings.PageSize.NorthAmericaLegalExtra:
                    return "North America Legal Extra";
                case
                PrintSettings.PageSize.NorthAmericaLetter:
                    return "North America Letter";
                case
                PrintSettings.PageSize.NorthAmericaLetterExtra:
                    return "North America Letter Extra";
                case
                PrintSettings.PageSize.NorthAmericaLetterPlus:
                    return "North America Letter Plus";
                case
                PrintSettings.PageSize.NorthAmericaLetterRotated:
                    return "North America Letter Rotated";
                case
                PrintSettings.PageSize.NorthAmericaMonarchEnvelope:
                    return "North America Monarch Envelope";
                case
                PrintSettings.PageSize.NorthAmericaNote:
                    return "North America Note";
                case
                PrintSettings.PageSize.NorthAmericaNumber10Envelope:
                    return "North America Number 10 Envelope";
                case
                PrintSettings.PageSize.NorthAmericaNumber10EnvelopeRotated:
                    return "North America Number 10 Envelope Rotated";
                case
                PrintSettings.PageSize.NorthAmericaNumber11Envelope:
                    return "North America Number 11 Envelope";
                case
                PrintSettings.PageSize.NorthAmericaNumber12Envelope:
                    return "North America Number 12 Envelope";
                case
                PrintSettings.PageSize.NorthAmericaNumber14Envelope:
                    return "North America Number 14 Envelope";
                case
                PrintSettings.PageSize.NorthAmericaNumber9Envelope:
                    return "North America Number 9 Envelope";
                case
                PrintSettings.PageSize.NorthAmericaPersonalEnvelope:
                    return "North America Personal Envelope";
                case
                PrintSettings.PageSize.NorthAmericaQuarto:
                    return "North America Quarto";
                case
                PrintSettings.PageSize.NorthAmericaStatement:
                    return "North America Statement";
                case
                PrintSettings.PageSize.NorthAmericaSuperA:
                    return "North America Super A";
                case
                PrintSettings.PageSize.NorthAmericaSuperB:
                    return "North America Super B";
                case
                PrintSettings.PageSize.NorthAmericaTabloid:
                    return "North America Tabloid";
                case
                PrintSettings.PageSize.NorthAmericaTabloidExtra:
                    return "North America Tabloid Extra";
                case
                PrintSettings.PageSize.OtherMetricA3Plus:
                    return "A3 Plus";
                case
                PrintSettings.PageSize.OtherMetricA4Plus:
                    return "A4 Plus";
                case
                PrintSettings.PageSize.OtherMetricFolio:
                    return "Folio";
                case
                PrintSettings.PageSize.OtherMetricInviteEnvelope:
                    return "Invite Envelope";
                case
                PrintSettings.PageSize.OtherMetricItalianEnvelope:
                    return "Italian Envelope";
                case
                PrintSettings.PageSize.PRC10Envelope:
                    return "PRC #10 Envelope";
                case
                PrintSettings.PageSize.PRC10EnvelopeRotated:
                    return "PRC #10 Envelope Rotated";
                case
                PrintSettings.PageSize.PRC16K:
                    return "PRC 16K";
                case
                PrintSettings.PageSize.PRC16KRotated:
                    return "PRC 16K Rotated";
                case
                PrintSettings.PageSize.PRC1Envelope:
                    return "PRC #1 Envelope";
                case
                PrintSettings.PageSize.PRC1EnvelopeRotated:
                    return "PRC #1 Envelope Rotated";
                case
                PrintSettings.PageSize.PRC2Envelope:
                    return "PRC #2 Envelope";
                case
                PrintSettings.PageSize.PRC2EnvelopeRotated:
                    return "PRC #2 Envelope Rotated";
                case
                PrintSettings.PageSize.PRC32K:
                    return "PRC 32K";
                case
                PrintSettings.PageSize.PRC32KBig:
                    return "PRC 32K Big";
                case
                PrintSettings.PageSize.PRC32KRotated:
                    return "PRC 32K Rotated";
                case
                PrintSettings.PageSize.PRC3Envelope:
                    return "PRC #3 Envelope";
                case
                PrintSettings.PageSize.PRC3EnvelopeRotated:
                    return "PRC #3 Envelope Rotated";
                case
                PrintSettings.PageSize.PRC4Envelope:
                    return "PRC #4 Envelope";
                case
                PrintSettings.PageSize.PRC4EnvelopeRotated:
                    return "PRC #4 Envelope Rotated";
                case
                PrintSettings.PageSize.PRC5Envelope:
                    return "PRC #5 Envelope";
                case
                PrintSettings.PageSize.PRC5EnvelopeRotated:
                    return "PRC #5 Envelope Rotated";
                case
                PrintSettings.PageSize.PRC6Envelope:
                    return "PRC #6 Envelope";
                case
                PrintSettings.PageSize.PRC6EnvelopeRotated:
                    return "PRC #6 Envelope Rotated";
                case
                PrintSettings.PageSize.PRC7Envelope:
                    return "PRC #7 Envelope";
                case
                PrintSettings.PageSize.PRC7EnvelopeRotated:
                    return "PRC #7 Envelope Rotated";
                case
                PrintSettings.PageSize.PRC8Envelope:
                    return "PRC #8 Envelope";
                case
                PrintSettings.PageSize.PRC8EnvelopeRotated:
                    return "PRC #8 Envelope Rotated";
                case
                PrintSettings.PageSize.PRC9Envelope:
                    return "PRC #9 Envelope";
                case
                PrintSettings.PageSize.PRC9EnvelopeRotated:
                    return "PRC #9 Envelope Rotated";
                case
                PrintSettings.PageSize.Roll04Inch:
                    return "4-inch Wide Roll";
                case
                PrintSettings.PageSize.Roll06Inch:
                    return "6-inch Wide Roll";
                case
                PrintSettings.PageSize.Roll08Inch:
                    return "8-inch Wide Roll";
                case
                PrintSettings.PageSize.Roll12Inch:
                    return "12-inch Wide Roll";
                case
                PrintSettings.PageSize.Roll15Inch:
                    return "15-inch Wide Roll";
                case
                PrintSettings.PageSize.Roll18Inch:
                    return "18-inch Wide Roll";
                case
                PrintSettings.PageSize.Roll22Inch:
                    return "22-inch Wide Roll";
                case
                PrintSettings.PageSize.Roll24Inch:
                    return "24-inch Wide Roll";
                case
                PrintSettings.PageSize.Roll30Inch:
                    return "30-inch Wide Roll";
                case
                PrintSettings.PageSize.Roll36Inch:
                    return "36-inch Wide Roll";
                case
                PrintSettings.PageSize.Roll54Inch:
                    return "54-inch Wide Roll";
                default: return "Unknown Size";
            }


        }


        public static string GetPageMediaTypeNameInfo(PageMediaType type)
        {

            switch (type)
            {
                case PageMediaType.Archival: return "Archival";
                case
                PageMediaType.AutoSelect:
                    return "Auto Select";
                case
                PageMediaType.BackPrintFilm:
                    return "Back Print Film";
                case
                PageMediaType.Bond:
                    return "Bond";
                case
                PageMediaType.CardStock:
                    return "Card Stock";
                case
                PageMediaType.Continuous:
                    return "Continuous";
                case
                PageMediaType.EnvelopePlain:
                    return "Envelope Plain";
                case
                PageMediaType.EnvelopeWindow:
                    return "Envelope Window";
                case
                PageMediaType.Fabric:
                    return "Fabric";
                case
                PageMediaType.HighResolution:
                    return "High Resolution";
                case
                PageMediaType.Label:
                    return "Label";
                case
                PageMediaType.MultiLayerForm:
                    return "Multi Layer Form";
                case
                PageMediaType.MultiPartForm:
                    return "Multi Part Form";
                case
                PageMediaType.Photographic:
                    return "Photographic";
                case
                PageMediaType.PhotographicFilm:
                    return "Photographic Film";
                case
                PageMediaType.PhotographicGlossy:
                    return "Photographic Glossy";
                case
                PageMediaType.PhotographicHighGloss:
                    return "Photographic High Gloss";
                case
                PageMediaType.PhotographicMatte:
                    return "Photographic Matte";
                case
                PageMediaType.PhotographicSatin:
                    return "Photographic Satin";
                case
                PageMediaType.PhotographicSemiGloss:
                    return "Photographic Semi Gloss";
                case
                PageMediaType.Plain:
                    return "Plain";
                case
                PageMediaType.Screen:
                    return "Screen";
                case
                PageMediaType.ScreenPaged:
                    return "Screen Paged";
                case
                PageMediaType.Stationery:
                    return "Stationery";
                case
                PageMediaType.TabStockFull:
                    return "Tab Stock Full";
                case
                PageMediaType.TabStockPreCut:
                    return "Tab Stock Pre Cut";
                case
                PageMediaType.Transparency:
                    return "Transparency";
                case
                PageMediaType.TShirtTransfer:
                    return "T-shirt Transfer";
                default: return "Unknown Type";

            }
        }

        public static string GetPageMediaTypeNameInfo(PrintSettings.PageType type)
        {
            switch (type)
            {
                case
 PrintSettings.PageType.Archival:
                    return "Archival";
                case
                PrintSettings.PageType.AutoSelect:
                    return "Auto Select";
                case
                PrintSettings.PageType.BackPrintFilm:
                    return "Back Print Film";
                case
                PrintSettings.PageType.Bond:
                    return "Bond";
                case
                PrintSettings.PageType.CardStock:
                    return "Card Stock";
                case
                PrintSettings.PageType.Continuous:
                    return "Continuous";
                case
                PrintSettings.PageType.EnvelopePlain:
                    return "Envelope Plain";
                case
                PrintSettings.PageType.EnvelopeWindow:
                    return "Envelope Window";
                case
                PrintSettings.PageType.Fabric:
                    return "Fabric";
                case
                PrintSettings.PageType.HighResolution:
                    return "High Resolution";
                case
                PrintSettings.PageType.Label:
                    return "Label";
                case
                PrintSettings.PageType.MultiLayerForm:
                    return "Multi Layer Form";
                case
                PrintSettings.PageType.MultiPartForm:
                    return "Multi Part Form";
                case
                PrintSettings.PageType.Photographic:
                    return "Photographic";
                case
                PrintSettings.PageType.PhotographicFilm:
                    return "Photographic Film";
                case
                PrintSettings.PageType.PhotographicGlossy:
                    return "Photographic Glossy";
                case
                PrintSettings.PageType.PhotographicHighGloss:
                    return "Photographic High Gloss";
                case
                PrintSettings.PageType.PhotographicMatte:
                    return "Photographic Matte";
                case
                PrintSettings.PageType.PhotographicSatin:
                    return "Photographic Satin";
                case
                PrintSettings.PageType.PhotographicSemiGloss:
                    return "Photographic Semi Gloss";
                case
                PrintSettings.PageType.Plain:
                    return "Plain";
                case
                PrintSettings.PageType.Screen:
                    return "Screen";
                case
                PrintSettings.PageType.ScreenPaged:
                    return "Screen Paged";
                case
                PrintSettings.PageType.Stationery:
                    return "Stationery";
                case
                PrintSettings.PageType.TabStockFull:
                    return "Tab Stock Full";
                case
                PrintSettings.PageType.TabStockPreCut:
                    return "Tab Stock Pre Cut";
                case
                PrintSettings.PageType.Transparency:
                    return "Transparency";
                case
                PrintSettings.PageType.TShirtTransfer:
                    return "T-shirt Transfer";
                default: return "Unknown Type";



            }

        }

        public static string GetInputBinNameInfo(InputBin inputBin)
        {
            switch (inputBin)
            {
                case
                 InputBin.AutoSelect:
                    return "Auto Select";
                case
                InputBin.AutoSheetFeeder:
                    return "Auto Sheet Feeder";
                case
                InputBin.Cassette:
                    return "Cassette";
                case
                InputBin.Manual:
                    return "Manual";
                case
                InputBin.Tractor:
                    return "Tractor";
                default: return "Unknown Input Bin";
            }
        }
    }
}
