using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTransferQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTransferQueryModel : AopObject
    {
        /// <summary>
        /// 透传信息
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 汇款请求id
        /// </summary>
        [XmlElement("transfer_request_id")]
        public string TransferRequestId { get; set; }
    }
}
