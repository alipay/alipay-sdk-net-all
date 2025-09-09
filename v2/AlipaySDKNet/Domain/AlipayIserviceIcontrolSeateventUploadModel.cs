using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIcontrolSeateventUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIcontrolSeateventUploadModel : AopObject
    {
        /// <summary>
        /// 坐席类型，有呼入和呼出
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 客服呼入类坐席事件上报报文
        /// </summary>
        [XmlElement("ic_inbound_seat_event_payload")]
        public IcInboundSeatEventModel IcInboundSeatEventPayload { get; set; }

        /// <summary>
        /// 星云侧服务收单的唯一编号，跟service_uniq_code一一对应
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 服务单类型： CUSTORMER_SERVICE_INBOUND: 客服-呼入类（客权客服
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 客服单次会话服务唯一标识,小二单次服务从接入到结束的唯一标识。若本次事件上报跟服务单相关，则该参数必填
        /// </summary>
        [XmlElement("service_uniq_code")]
        public string ServiceUniqCode { get; set; }
    }
}
