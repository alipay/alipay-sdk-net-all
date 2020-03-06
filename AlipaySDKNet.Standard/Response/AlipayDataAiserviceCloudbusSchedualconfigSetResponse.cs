using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualconfigSetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualconfigSetResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ScheduleConfigResult Result { get; set; }
    }
}
