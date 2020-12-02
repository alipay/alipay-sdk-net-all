using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderExtIstd Data Structure.
    /// </summary>
    [Serializable]
    public class OrderExtIstd : AopObject
    {
        /// <summary>
        /// 骑手应付金额
        /// </summary>
        [XmlElement("cash_on_delivery")]
        public string CashOnDelivery { get; set; }

        /// <summary>
        /// 骑手应收金额
        /// </summary>
        [XmlElement("cash_on_pickup")]
        public string CashOnPickup { get; set; }

        /// <summary>
        /// 消费者下单时间
        /// </summary>
        [XmlElement("consumer_order_time")]
        public string ConsumerOrderTime { get; set; }

        /// <summary>
        /// 物流流向，1：从门店取件送至用户；2：从用户取件送至门店
        /// </summary>
        [XmlElement("delivery_direction")]
        public long DeliveryDirection { get; set; }

        /// <summary>
        /// 配送类型, 0: 即时单 1 预约单
        /// </summary>
        [XmlElement("delivery_type")]
        public long DeliveryType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 期望派单时间
        /// </summary>
        [XmlElement("expected_delivery_time")]
        public string ExpectedDeliveryTime { get; set; }

        /// <summary>
        /// 期望送达时间
        /// </summary>
        [XmlElement("expected_finish_time")]
        public string ExpectedFinishTime { get; set; }

        /// <summary>
        /// 期望取件时间
        /// </summary>
        [XmlElement("expected_pick_time")]
        public string ExpectedPickTime { get; set; }

        /// <summary>
        /// 保价金额
        /// </summary>
        [XmlElement("insure_price")]
        public string InsurePrice { get; set; }

        /// <summary>
        /// 是否直拿直送，1:直拿直送 0:非直拿直送
        /// </summary>
        [XmlElement("is_direct_delivery")]
        public long IsDirectDelivery { get; set; }

        /// <summary>
        /// 是否需要收货码，1:需要 0:不需要
        /// </summary>
        [XmlElement("is_finish_code_needed")]
        public long IsFinishCodeNeeded { get; set; }

        /// <summary>
        /// 是否保价，1:保价 0:不保价
        /// </summary>
        [XmlElement("is_insured")]
        public long IsInsured { get; set; }

        /// <summary>
        /// 是否需要取货码，1:需要 0:不需要
        /// </summary>
        [XmlElement("is_pickup_code_needed")]
        public long IsPickupCodeNeeded { get; set; }

        /// <summary>
        /// 门店订单流水号
        /// </summary>
        [XmlElement("poi_seq")]
        public string PoiSeq { get; set; }
    }
}
