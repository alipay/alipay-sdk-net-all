using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantPriceRelatedInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantPriceRelatedInfo : AopObject
    {
        /// <summary>
        /// 安心付直联版后台产品code使用商家扣款（I1140100001000001000）、间联版不需要填
        /// </summary>
        [XmlElement("back_product_code")]
        public string BackProductCode { get; set; }

        /// <summary>
        /// 费率，最多两位小数，范围为0.38～0.6，单位为%。 周期卡间联版没有收费协议该字段可不填
        /// </summary>
        [XmlElement("price_rate")]
        public string PriceRate { get; set; }
    }
}
