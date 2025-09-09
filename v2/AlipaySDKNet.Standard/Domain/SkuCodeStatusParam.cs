using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuCodeStatusParam Data Structure.
    /// </summary>
    [Serializable]
    public class SkuCodeStatusParam : AopObject
    {
        /// <summary>
        /// 商家商品sku编码
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }

        /// <summary>
        /// 商品状态, 0上架, -1下架
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
