using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportRailwayTradeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportRailwayTradeSyncModel : AopObject
    {
        /// <summary>
        /// 业务日期，用于判断对账时间，格式为yyyyMMdd
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 数据版本号，从1开始。当铁路需要修改订单信息时，新增一个版本号并重传所有数据
        /// </summary>
        [XmlElement("data_version")]
        public long DataVersion { get; set; }

        /// <summary>
        /// 扩展字段，具体取值需要双方沟通
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 用户的蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 当前订单金额，精确到分
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 当前业务日期里所有订单的总金额，精确到分
        /// </summary>
        [XmlElement("order_total_amount")]
        public string OrderTotalAmount { get; set; }

        /// <summary>
        /// 业务日期里所有订单的总笔数
        /// </summary>
        [XmlElement("order_total_num")]
        public long OrderTotalNum { get; set; }

        /// <summary>
        /// 外部交易号。铁路在收单请求时传递给支付宝，支付宝根据该单据号进行幂等控制
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 本次数据同步请求ID，支付宝根据此ID进行数据同步幂等控制，铁路侧需要自行保证该ID唯一
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 收款PID，不同路局可能使用不同seller_id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 支付宝交易号，铁路无此单号时允许为空。如非空则优先使用该参数查询支付宝订单
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 用户的蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
