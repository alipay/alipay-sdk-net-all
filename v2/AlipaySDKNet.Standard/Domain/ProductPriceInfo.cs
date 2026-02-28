using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductPriceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ProductPriceInfo : AopObject
    {
        /// <summary>
        /// 产品开通明细项费率，单位：只可以小数不能填百分号，最多小数点后两位，范围为0.38～1.0。
        /// </summary>
        [XmlElement("price_rate")]
        public string PriceRate { get; set; }

        /// <summary>
        /// 产品开通明细项编码
        /// </summary>
        [XmlElement("product_detail_code")]
        public string ProductDetailCode { get; set; }
    }
}
