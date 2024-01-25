using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderAftersaleQueryResponse.
    /// </summary>
    public class AlipayOpenMiniOrderAftersaleQueryResponse : AopResponse
    {
        /// <summary>
        /// 售后单触发类型
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 用户售后发起原因
        /// </summary>
        [XmlElement("aftersale_reason")]
        public string AftersaleReason { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部售后单号
        /// </summary>
        [XmlElement("out_aftersale_id")]
        public string OutAftersaleId { get; set; }

        /// <summary>
        /// 售后单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 售后类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
