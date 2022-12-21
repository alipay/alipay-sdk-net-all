using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsGreenenergyCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsGreenenergyCheckModel : AopObject
    {
        /// <summary>
        /// 用户支付宝OPENID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单交易状态，verify_succ-已使用，目前仅支持对已使用的订单发放能量
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部系统中的订单ID，唯一键
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 订单金额(单位：元)，保留两位小数
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易所属pid，一般为发起交易的应用配置的pid
        /// </summary>
        [XmlElement("trade_partner_id")]
        public string TradePartnerId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
