using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAeprepayOrderSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAeprepayOrderSendModel : AopObject
    {
        /// <summary>
        /// 扩展预留字段
        /// </summary>
        [XmlElement("ext_param")]
        public ZmEpAePrepayExtParam ExtParam { get; set; }

        /// <summary>
        /// 订单金额。币种最小单位，如人民币：分
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单币种
        /// </summary>
        [XmlElement("order_currency")]
        public string OrderCurrency { get; set; }

        /// <summary>
        /// 审核单创建时间时间戳
        /// </summary>
        [XmlElement("order_time_millis")]
        public string OrderTimeMillis { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("reference_code")]
        public string ReferenceCode { get; set; }

        /// <summary>
        /// AE侧商家登陆id
        /// </summary>
        [XmlElement("seller_login_id")]
        public string SellerLoginId { get; set; }

        /// <summary>
        /// 审核阶段。针对海外本对本订单下游消费该字段 其中1代表发货，2代表确认收货
        /// </summary>
        [XmlElement("stage")]
        public string Stage { get; set; }
    }
}
