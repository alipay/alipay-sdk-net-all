using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinancePfApplySendResponse.
    /// </summary>
    public class AnttechBlockchainFinancePfApplySendResponse : AopResponse
    {
        /// <summary>
        /// 支用标识
        /// </summary>
        [XmlElement("financing_id")]
        public string FinancingId { get; set; }

        /// <summary>
        /// passed
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 平台标识
        /// </summary>
        [XmlElement("platform_id")]
        public string PlatformId { get; set; }
    }
}
