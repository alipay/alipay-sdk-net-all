using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphoneRoutehubQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationCreditphoneRoutehubQueryModel : AopObject
    {
        /// <summary>
        /// 机构PID
        /// </summary>
        [XmlElement("inst_pid")]
        public string InstPid { get; set; }

        /// <summary>
        /// 运营商侧订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 查询类型
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 请求流水号（TRANSFER、TRANSFER_REFUND、UNBIND）
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 交易流水号（SIGN、TRANSFER_REFUND、UNBIND）
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
