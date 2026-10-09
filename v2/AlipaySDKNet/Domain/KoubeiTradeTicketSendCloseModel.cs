using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiTradeTicketSendCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeTicketSendCloseModel : AopObject
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 停止发码原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 外部请求流水号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 口碑商品发货单号
        /// </summary>
        [XmlElement("send_order_no")]
        public string SendOrderNo { get; set; }

        /// <summary>
        /// 凭证发放token
        /// </summary>
        [XmlElement("send_token")]
        public string SendToken { get; set; }
    }
}
