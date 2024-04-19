using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskodQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletaskodQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ScheduleOdResult Result { get; set; }
    }
}
