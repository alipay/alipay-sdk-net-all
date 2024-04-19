using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTransferConfirmResponse.
    /// </summary>
    public class AlipayOverseasTransferConfirmResponse : AopResponse
    {
        /// <summary>
        /// {}
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 汇款id
        /// </summary>
        [XmlElement("transfer_id")]
        public string TransferId { get; set; }
    }
}
