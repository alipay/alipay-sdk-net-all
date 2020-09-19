using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusResourceUploadResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusResourceUploadResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public CloudbusCommonResult Result { get; set; }
    }
}
