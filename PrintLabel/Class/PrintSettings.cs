using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLabel.PrintSettings
{
    public enum PageOrientation
    {

        Portrait,


        Landscape
    }

    public enum PageColor
    {
        Color,

        Grayscale,

        Monochrome
    }

    public enum PageQuality
    {
        Automatic,

        Draft,

        Fax,

        High,

        Normal,

        Photographic,

        Text
    }

    public enum PageSize
    {
        ISOA0,

        ISOA1,

        ISOA10,

        ISOA2,

        ISOA3,

        ISOA3Rotated,

        ISOA3Extra,

        ISOA4,

        ISOA4Rotated,

        ISOA4Extra,

        ISOA5,

        ISOA5Rotated,

        ISOA5Extra,

        ISOA6,

        ISOA6Rotated,

        ISOA7,

        ISOA8,

        ISOA9,

        ISOB0,

        ISOB1,

        ISOB10,

        ISOB2,

        ISOB3,

        ISOB4,

        ISOB4Envelope,

        ISOB5Envelope,

        ISOB5Extra,

        ISOB7,

        ISOB8,

        ISOB9,

        ISOC0,

        ISOC1,

        ISOC10,

        ISOC2,

        ISOC3,

        ISOC3Envelope,

        ISOC4,

        ISOC4Envelope,

        ISOC5,

        ISOC5Envelope,

        ISOC6,

        ISOC6Envelope,

        ISOC6C5Envelope,

        ISOC7,

        ISOC8,

        ISOC9,

        ISODLEnvelope,

        ISODLEnvelopeRotated,

        ISOSRA3,

        JapanQuadrupleHagakiPostcard,

        JISB0,

        JISB1,

        JISB10,

        JISB2,

        JISB3,

        JISB4,

        JISB4Rotated,

        JISB5,

        JISB5Rotated,

        JISB6,

        JISB6Rotated,

        JISB7,

        JISB8,

        JISB9,

        JapanChou3Envelope,

        JapanChou3EnvelopeRotated,

        JapanChou4Envelope,

        JapanChou4EnvelopeRotated,

        JapanHagakiPostcard,

        JapanHagakiPostcardRotated,

        JapanKaku2Envelope,

        JapanKaku2EnvelopeRotated,

        JapanKaku3Envelope,

        JapanKaku3EnvelopeRotated,

        JapanYou4Envelope,

        NorthAmerica10x11,

        NorthAmerica10x14,

        NorthAmerica11x17,

        NorthAmerica9x11,

        NorthAmericaArchitectureASheet,

        NorthAmericaArchitectureBSheet,

        NorthAmericaArchitectureCSheet,

        NorthAmericaArchitectureDSheet,

        NorthAmericaArchitectureESheet,

        NorthAmericaCSheet,

        NorthAmericaDSheet,

        NorthAmericaESheet,

        NorthAmericaExecutive,

        NorthAmericaGermanLegalFanfold,

        NorthAmericaGermanStandardFanfold,

        NorthAmericaLegal,

        NorthAmericaLegalExtra,

        NorthAmericaLetter,

        NorthAmericaLetterRotated,

        NorthAmericaLetterExtra,

        NorthAmericaLetterPlus,

        NorthAmericaMonarchEnvelope,

        NorthAmericaNote,

        NorthAmericaNumber10Envelope,

        NorthAmericaNumber10EnvelopeRotated,

        NorthAmericaNumber9Envelope,

        NorthAmericaNumber11Envelope,

        NorthAmericaNumber12Envelope,

        NorthAmericaNumber14Envelope,

        NorthAmericaPersonalEnvelope,

        NorthAmericaQuarto,

        NorthAmericaStatement,

        NorthAmericaSuperA,

        NorthAmericaSuperB,

        NorthAmericaTabloid,

        NorthAmericaTabloidExtra,

        OtherMetricA4Plus,

        OtherMetricA3Plus,

        OtherMetricFolio,

        OtherMetricInviteEnvelope,

        OtherMetricItalianEnvelope,

        PRC1Envelope,

        PRC1EnvelopeRotated,

        PRC10Envelope,

        PRC10EnvelopeRotated,

        PRC16K,

        PRC16KRotated,

        PRC2Envelope,

        PRC2EnvelopeRotated,

        PRC32K,

        PRC32KRotated,

        PRC32KBig,

        PRC3Envelope,

        PRC3EnvelopeRotated,

        PRC4Envelope,

        PRC4EnvelopeRotated,

        PRC5Envelope,

        PRC5EnvelopeRotated,

        PRC6Envelope,

        PRC6EnvelopeRotated,

        PRC7Envelope,

        PRC7EnvelopeRotated,

        PRC8Envelope,

        PRC8EnvelopeRotated,

        PRC9Envelope,

        PRC9EnvelopeRotated,

        Roll04Inch,

        Roll06Inch,

        Roll08Inch,

        Roll12Inch,

        Roll15Inch,

        Roll18Inch,

        Roll22Inch,

        Roll24Inch,

        Roll30Inch,

        Roll36Inch,

        Roll54Inch,

        JapanDoubleHagakiPostcard,

        JapanDoubleHagakiPostcardRotated,

        JapanLPhoto,

        Japan2LPhoto,

        JapanYou1Envelope,

        JapanYou2Envelope,

        JapanYou3Envelope,

        JapanYou4EnvelopeRotated,

        JapanYou6Envelope,

        JapanYou6EnvelopeRotated,

        NorthAmerica4x6,

        NorthAmerica4x8,

        NorthAmerica5x7,

        NorthAmerica8x10,

        NorthAmerica10x12,

        NorthAmerica14x17,

        BusinessCard,

        CreditCard
    }

    public enum PageType
    {
        AutoSelect,

        Archival,

        BackPrintFilm,

        Bond,

        CardStock,

        Continuous,

        EnvelopePlain,

        EnvelopeWindow,

        Fabric,

        HighResolution,

        Label,

        MultiLayerForm,

        MultiPartForm,

        Photographic,

        PhotographicFilm,

        PhotographicGlossy,

        PhotographicHighGloss,

        PhotographicMatte,

        PhotographicSatin,

        PhotographicSemiGloss,

        Plain,

        Screen,

        ScreenPaged,

        Stationery,

        TabStockFull,

        TabStockPreCut,

        Transparency,

        TShirtTransfer
    }

    public enum TwoSided
    {
        OneSided,

        TwoSidedShortEdge,

        TwoSidedLongEdge
    }

    public enum PageOrder
    {
        Horizontal,

        HorizontalReverse,

        Vertical,

        VerticalReverse
    }
}
