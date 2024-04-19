using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignUnicardExcodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignUnicardExcodeQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝内部生成的兑换码，商家可用该兑换码作为商品出售，用户用兑换码可来支付宝兑换权益。
        /// </summary>
        [XmlElement("exchange_code")]
        public string ExchangeCode { get; set; }
    }
}
