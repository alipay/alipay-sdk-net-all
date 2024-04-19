using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoterExchangeSubmitResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoterExchangeSubmitResponse : AopResponse
    {
        /// <summary>
        /// 积分兑换奖品处理结果
        /// </summary>
        [XmlElement("exchange_order_result")]
        public ExchangeOrderInfo ExchangeOrderResult { get; set; }
    }
}
