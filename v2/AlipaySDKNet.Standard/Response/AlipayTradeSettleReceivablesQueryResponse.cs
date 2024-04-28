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
        /// 直付通请款模式下的结算在途金额，发起结算后 T+N 日到账场景下的处理中金额，人民币，单位为元
        /// </summary>
        [XmlElement("on_settle_amount")]
        public string OnSettleAmount { get; set; }

        /// <summary>
        /// 已结算金额，人民币，单位为元
        /// </summary>
        [XmlElement("settled_amount")]
        public string SettledAmount { get; set; }

        /// <summary>
        /// 待结算金额，人民币，单位为元
        /// </summary>
        [XmlElement("unsettled_amount")]
        public string UnsettledAmount { get; set; }
    }
}
