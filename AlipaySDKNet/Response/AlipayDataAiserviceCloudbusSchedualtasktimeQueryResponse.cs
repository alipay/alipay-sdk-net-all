using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualtasktimeQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualtasktimeQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ScheduleTimeResult Result { get; set; }
    }
}
