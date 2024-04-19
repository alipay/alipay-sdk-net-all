using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskshiftAddResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletaskshiftAddResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public CloudbusCommonResult Result { get; set; }
    }
}
