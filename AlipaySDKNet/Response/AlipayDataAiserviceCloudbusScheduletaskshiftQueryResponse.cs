using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskshiftQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletaskshiftQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ScheduleShiftResult Result { get; set; }
    }
}
