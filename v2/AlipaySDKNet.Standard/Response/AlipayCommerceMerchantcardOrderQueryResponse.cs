using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 售卖订单信息
        /// </summary>
        [XmlElement("card_order_info")]
        public CardOrderInfo CardOrderInfo { get; set; }
    }
}
