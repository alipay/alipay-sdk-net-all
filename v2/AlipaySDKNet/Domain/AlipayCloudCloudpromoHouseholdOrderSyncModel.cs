using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoHouseholdOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoHouseholdOrderSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝生成的订单id，没有则不传
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 主单id
        /// </summary>
        [XmlElement("main_order_id")]
        public string MainOrderId { get; set; }

        /// <summary>
        /// 订单金额，单位为元
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 工单id，没有则不传
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 用于描述订单状态
        /// </summary>
        [XmlElement("order_stat")]
        public string OrderStat { get; set; }

        /// <summary>
        /// yyyy-MM-dd HH:mm:ss格式
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 订单展示标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 订单来源平台
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 订单的预估金额，单位为元。和订单金额不可同时为空
        /// </summary>
        [XmlElement("pre_amount")]
        public string PreAmount { get; set; }
    }
}
