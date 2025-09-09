using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayVoyagerFlightSupplierNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayVoyagerFlightSupplierNotifyModel : AopObject
    {
        /// <summary>
        /// 通知事件类型。 ORDER_CREATED_EVENT：订单创建事件 ORDER_PAID_DONE_EVENT：订单支付完成事件 ORDER_TICKET_ISSUED_EVENT：出票成功事件 ORDER_CLOSED_EVENT：订单关闭事件 ORDER_REFUND_CREATED_EVENT：退票申请事件 ORDER_REFUND_APPROVED_EVENT：同意退款事件 ORDER_REFUND_REJECTED_EVENT：退款拒绝事件 ORDER_FLIGHT_CHANGED_EVENT：航变-航程变更事件 ORDER_FLIGHT_CANCELLED_EVENT：航变-航程取消事件 ORDER_REBOOK_CREATED_EVENT: 改签-提交改签 ORDER_REBOOK_SUCC_EVENT: 改签-改签成功 ORDER_REBOOK_FAILED_EVENT：改签-改签失败 ORDER_REFUND_FY_APPROVED_EVENT:辅营退款成功 ORDER_FY_PAID_DONE_EVENT：辅营支付成功
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 事件发生的时间，为时间戳
        /// </summary>
        [XmlElement("occurrence_time")]
        public long OccurrenceTime { get; set; }

        /// <summary>
        /// 用于Voyager唯一识别对应供应商订单
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 改签明细集合
        /// </summary>
        [XmlElement("rebook_info")]
        public VoyagerOrderRebookInfo RebookInfo { get; set; }

        /// <summary>
        /// 供应商退款单号，用于Voyager识别对应退款单。退款相关事件时必传。
        /// </summary>
        [XmlElement("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 事件为ORDER_FLIGHT_CANCELLED_EVENT传入如，每个乘机人的航段信息，每条记录是一个乘机人，按乘机人做了聚合
        /// </summary>
        [XmlArray("segment_of_passengers_cancelled")]
        [XmlArrayItem("voyager_segment_of_passengers_cancelled_info")]
        public List<VoyagerSegmentOfPassengersCancelledInfo> SegmentOfPassengersCancelled { get; set; }

        /// <summary>
        /// 事件类型为ORDER_FLIGHT_CHANGED_EVENT时传入，每个乘机人的航段信息，每条记录是一个乘机人，按乘机人做了聚合
        /// </summary>
        [XmlArray("segment_of_passengers_changed")]
        [XmlArrayItem("voyager_segment_of_passengers_changed_info")]
        public List<VoyagerSegmentOfPassengersChangedInfo> SegmentOfPassengersChanged { get; set; }

        /// <summary>
        /// 人航段维度退票信息集合
        /// </summary>
        [XmlArray("segment_of_passengers_refund_info")]
        [XmlArrayItem("voyager_segment_of_passengers_cancelled_info")]
        public List<VoyagerSegmentOfPassengersCancelledInfo> SegmentOfPassengersRefundInfo { get; set; }
    }
}
