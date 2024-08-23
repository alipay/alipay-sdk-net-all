using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantPriceRelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantPriceRelInfo : AopObject
    {
        /// <summary>
        /// 后台产品code
        /// </summary>
        [XmlElement("back_product_code")]
        public string BackProductCode { get; set; }

        /// <summary>
        /// 费率，最多两位小数，范围为0.38～0.6。
        /// </summary>
        [XmlElement("price_rate")]
        public string PriceRate { get; set; }
    }
}
