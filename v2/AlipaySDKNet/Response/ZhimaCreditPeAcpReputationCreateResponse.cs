using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeAcpReputationCreateResponse.
    /// </summary>
    public class ZhimaCreditPeAcpReputationCreateResponse : AopResponse
    {
        /// <summary>
        /// 声誉事件i
        /// </summary>
        [XmlElement("reputation_id")]
        public string ReputationId { get; set; }
    }
}
