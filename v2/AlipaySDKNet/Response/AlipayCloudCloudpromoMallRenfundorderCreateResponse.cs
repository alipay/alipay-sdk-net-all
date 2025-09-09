using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMallRenfundorderCreateResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMallRenfundorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 纠纷id
        /// </summary>
        [XmlElement("dispute_id")]
        public string DisputeId { get; set; }

        /// <summary>
        /// 逆向的状态
        /// </summary>
        [XmlElement("dispute_status")]
        public string DisputeStatus { get; set; }

        /// <summary>
        /// 子分销订单号
        /// </summary>
        [XmlElement("order_line_id")]
        public string OrderLineId { get; set; }
    }
}
