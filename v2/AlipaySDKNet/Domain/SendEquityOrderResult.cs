using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SendEquityOrderResult Data Structure.
    /// </summary>
    [Serializable]
    public class SendEquityOrderResult : AopObject
    {
        /// <summary>
        /// 权益唯一id标识，摩斯生成的权益id，用于商户端标识权益信息
        /// </summary>
        [XmlElement("equity_id")]
        public string EquityId { get; set; }

        /// <summary>
        /// 发奖的权益奖品类型
        /// </summary>
        [XmlElement("equity_type")]
        public string EquityType { get; set; }

        /// <summary>
        /// 权益发放的订单唯一id标识
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 发奖订单的结果码
        /// </summary>
        [XmlElement("order_result_code")]
        public string OrderResultCode { get; set; }

        /// <summary>
        /// 发奖订单结果信息
        /// </summary>
        [XmlElement("order_result_msg")]
        public string OrderResultMsg { get; set; }

        /// <summary>
        /// 发奖订单的状态信息
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 发奖订单发生时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }
    }
}
