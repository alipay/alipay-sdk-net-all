using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSettleReceivablesQueryResponse.
    /// </summary>
    public class AlipayTradeSettleReceivablesQueryResponse : AopResponse
    {
        /// <summary>
        /// 待结算金额，人民币，单位为元
        /// </summary>
        [XmlElement("unsettled_amount")]
        public string UnsettledAmount { get; set; }
    }
}
