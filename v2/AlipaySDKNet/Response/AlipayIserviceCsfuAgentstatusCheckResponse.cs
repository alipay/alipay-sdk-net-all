using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCsfuAgentstatusCheckResponse.
    /// </summary>
    public class AlipayIserviceCsfuAgentstatusCheckResponse : AopResponse
    {
        /// <summary>
        /// true：坐席空闲 false：坐席繁忙
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
