using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthCardinfoCheckResponse.
    /// </summary>
    public class AlipayFinancialnetAuthCardinfoCheckResponse : AopResponse
    {
        /// <summary>
        /// 入参开启卡bin校验时，卡bin校验结果的发卡机构
        /// </summary>
        [XmlElement("bank")]
        public string Bank { get; set; }

        /// <summary>
        /// 缓存卡信息到缓存后的key值
        /// </summary>
        [XmlElement("cache_key")]
        public string CacheKey { get; set; }

        /// <summary>
        /// 如果开启卡bin校验该值为卡bin校验结果中的卡类型（信用卡/借记卡）
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 如果入参开启卡bin校验该值为卡bin校验结果
        /// </summary>
        [XmlElement("validated")]
        public bool Validated { get; set; }
    }
}
