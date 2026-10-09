using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCstrainingOrgstructureCreateormodifyResponse.
    /// </summary>
    public class AlipayIserviceCstrainingOrgstructureCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
