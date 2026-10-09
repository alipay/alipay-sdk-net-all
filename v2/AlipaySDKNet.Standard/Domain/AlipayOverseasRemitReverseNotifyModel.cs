using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasRemitReverseNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasRemitReverseNotifyModel : AopObject
    {
        /// <summary>
        /// 拓展信息
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 退票请求金额，单位为最小币种单位，如人民币的分、港币的分、日元的元
        /// </summary>
        [XmlElement("reverse_from_amount")]
        public Money ReverseFromAmount { get; set; }

        /// <summary>
        /// 退票ID
        /// </summary>
        [XmlElement("reverse_id")]
        public string ReverseId { get; set; }

        /// <summary>
        /// 退票汇率,格式为json
        /// </summary>
        [XmlElement("reverse_quote")]
        public string ReverseQuote { get; set; }

        /// <summary>
        /// 退票原因
        /// </summary>
        [XmlElement("reverse_reason")]
        public string ReverseReason { get; set; }

        /// <summary>
        /// 退票原因信息
        /// </summary>
        [XmlElement("reverse_reason_message")]
        public string ReverseReasonMessage { get; set; }

        /// <summary>
        /// 退票请求单号
        /// </summary>
        [XmlElement("reverse_request_id")]
        public string ReverseRequestId { get; set; }

        /// <summary>
        /// 退票结果
        /// </summary>
        [XmlElement("reverse_result")]
        public string ReverseResult { get; set; }

        /// <summary>
        /// 时间字符串
        /// </summary>
        [XmlElement("reverse_time")]
        public string ReverseTime { get; set; }

        /// <summary>
        /// 退票目标金额，单位为最小币种单位，如人民币的分、港币的分、日元的元
        /// </summary>
        [XmlElement("reverse_to_amount")]
        public Money ReverseToAmount { get; set; }

        /// <summary>
        /// 汇款请求单号
        /// </summary>
        [XmlElement("transfer_request_id")]
        public string TransferRequestId { get; set; }
    }
}
