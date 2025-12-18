using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingQualificationReleaseResponse.
    /// </summary>
    public class AlipayMarketingQualificationReleaseResponse : AopResponse
    {
        /// <summary>
        /// 资格ID
        /// </summary>
        [XmlElement("qual_id")]
        public string QualId { get; set; }

        /// <summary>
        /// 资格实例ID
        /// </summary>
        [XmlElement("qual_instance_id")]
        public string QualInstanceId { get; set; }
    }
}
