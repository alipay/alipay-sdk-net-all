using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualconfigGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualconfigGetResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ScheduleConfigGetResult Result { get; set; }
    }
}
