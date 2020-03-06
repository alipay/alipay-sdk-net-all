using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletasklistQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletasklistQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ScheduleListResult Result { get; set; }
    }
}
