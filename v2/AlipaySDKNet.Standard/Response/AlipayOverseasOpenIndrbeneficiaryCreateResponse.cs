using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenIndrbeneficiaryCreateResponse.
    /// </summary>
    public class AlipayOverseasOpenIndrbeneficiaryCreateResponse : AopResponse
    {
        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("result")]
        public IndrISVResult Result { get; set; }
    }
}
