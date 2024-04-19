using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusResourceQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusResourceQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ScheduleResResult Result { get; set; }
    }
}
