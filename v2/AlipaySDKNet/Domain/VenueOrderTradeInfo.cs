using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VenueOrderTradeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VenueOrderTradeInfo : AopObject
    {
        /// <summary>
        /// 金额(单位：元)，保留两位小数。支付时为订单金额、退款时为交易退款金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 操作描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 交易记录号，须保证单笔订单内唯一，不重复。
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 买家支付宝OPENID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 该交易操作发起的时间
        /// </summary>
        [XmlElement("operation_time")]
        public string OperationTime { get; set; }

        /// <summary>
        /// 交易所属pid，一般为发起交易的应用配置的pid。
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 支付宝退款交易的请求号，标识一次退款请求，对应发起退款时的out_request_no。交易类型为退款时必传。
        /// </summary>
        [XmlElement("refund_request_no")]
        public string RefundRequestNo { get; set; }

        /// <summary>
        /// 支付宝交易单号，本条记录对应的交易信息。如果是支付行为，则直接为交易单号；如果是基于原支付交易单原路返还退款，则为原支付交易单号；
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易类型，包括'pay'-支付、'refund'-退款
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 用户在支付宝的用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
