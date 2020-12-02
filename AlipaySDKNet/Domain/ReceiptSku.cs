using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReceiptSku Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiptSku : AopObject
    {
        /// <summary>
        /// 商品条形码
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品价格，单位分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }
    }
}
