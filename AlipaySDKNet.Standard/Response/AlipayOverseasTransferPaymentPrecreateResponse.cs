using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTransferPaymentPrecreateResponse.
    /// </summary>
    public class AlipayOverseasTransferPaymentPrecreateResponse : AopResponse
    {
        /// <summary>
        /// pass_through_info
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// transfer_id
        /// </summary>
        [XmlElement("transfer_id")]
        public string TransferId { get; set; }
    }
}
