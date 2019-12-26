using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeIndustryOrderQueryResponse.
    /// </summary>
    public class ZhimaCreditPeIndustryOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 入参传入的外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 订单状态,具体业务对应的订单状态值请联系业务确认
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("zm_order_id")]
        public string ZmOrderId { get; set; }
    }
}
