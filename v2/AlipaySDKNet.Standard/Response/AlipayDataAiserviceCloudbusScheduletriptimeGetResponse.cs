using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletriptimeGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletriptimeGetResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ScheduleTripResult Result { get; set; }
    }
}
