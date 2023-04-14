using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTransferCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTransferCancelModel : AopObject
    {
        /// <summary>
        /// 撤销原因
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 透传信息
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        [XmlElement("transfer_request_id")]
        public string TransferRequestId { get; set; }
    }
}
