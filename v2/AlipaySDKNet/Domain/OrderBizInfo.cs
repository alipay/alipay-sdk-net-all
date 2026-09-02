using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderBizInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderBizInfo : AopObject
    {
        /// <summary>
        /// 订单优惠后金额
        /// </summary>
        [XmlElement("amount_discount")]
        public string AmountDiscount { get; set; }

        /// <summary>
        /// 订单原始价格
        /// </summary>
        [XmlElement("amount_original")]
        public string AmountOriginal { get; set; }

        /// <summary>
        /// 营销折扣信息
        /// </summary>
        [XmlArray("discount_info")]
        [XmlArrayItem("health_discount_info")]
        public List<HealthDiscountInfo> DiscountInfo { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单详情链接
        /// </summary>
        [XmlElement("order_detail_url")]
        public string OrderDetailUrl { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public long OrderStatus { get; set; }

        /// <summary>
        /// 支付过期时间
        /// </summary>
        [XmlElement("pay_expire_time")]
        public string PayExpireTime { get; set; }
    }
}
