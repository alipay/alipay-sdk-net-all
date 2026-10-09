using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoterExchangeConfirmResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoterExchangeConfirmResponse : AopResponse
    {
        /// <summary>
        /// 积分兑换奖品信息
        /// </summary>
        [XmlElement("item_exchange_info")]
        public ItemExchangeInfo ItemExchangeInfo { get; set; }
    }
}
