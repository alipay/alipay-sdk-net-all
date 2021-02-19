using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeServiceAccountQueryResponse.
    /// </summary>
    public class AlipayTradeServiceAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 无限付产品账户卡信息
        /// </summary>
        [XmlElement("large_infinite_card_info")]
        public LargeInfiniteCardInfo LargeInfiniteCardInfo { get; set; }
    }
}
