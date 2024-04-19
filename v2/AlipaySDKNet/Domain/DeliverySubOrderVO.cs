using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliverySubOrderVO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliverySubOrderVO : AopObject
    {
        /// <summary>
        /// (预计)配送日期
        /// </summary>
        [XmlElement("delivery_date")]
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 配送期数
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }

        /// <summary>
        /// 配送订单信息 1. 待发货：wait_delivered 2. 已发货：delivered 3. 确认收货：delivered_confirmed 4. 退款中：refunding 5. 退款完成：refund
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
