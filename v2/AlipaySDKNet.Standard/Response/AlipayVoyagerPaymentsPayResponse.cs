using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerPaymentsPayResponse.
    /// </summary>
    public class AlipayVoyagerPaymentsPayResponse : AopResponse
    {
        /// <summary>
        /// 支付链接
        /// </summary>
        [XmlElement("order_str")]
        public string OrderStr { get; set; }

        /// <summary>
        /// 支付单ID
        /// </summary>
        [XmlElement("pay_order_id")]
        public string PayOrderId { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }
    }
}
