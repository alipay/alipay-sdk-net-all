using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BarcodeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BarcodeInfo : AopObject
    {
        /// <summary>
        /// 条形码数字字符串
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 条形码类型, 目前支持 ean8、ean13，前者对应的 barcode 为 8 位纯数字字符串，后者为 13 位纯数字字符串。
        /// </summary>
        [XmlElement("barcode_type")]
        public string BarcodeType { get; set; }
    }
}
