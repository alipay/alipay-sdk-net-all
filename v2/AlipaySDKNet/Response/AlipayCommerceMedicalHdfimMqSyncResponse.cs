using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfimMqSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfimMqSyncResponse : AopResponse
    {
        /// <summary>
        /// 实际转发的SOFAMQ tag
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 实际转发的SOFAMQ topic
        /// </summary>
        [XmlElement("topic")]
        public string Topic { get; set; }
    }
}
