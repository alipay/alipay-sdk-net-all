using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundedRecordListDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RefundedRecordListDTO : AopObject
    {
        /// <summary>
        /// 此次退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款触发时间
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 商户退款请求号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
