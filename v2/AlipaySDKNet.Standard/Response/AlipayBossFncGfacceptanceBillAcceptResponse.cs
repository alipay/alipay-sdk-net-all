using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfacceptanceBillAcceptResponse.
    /// </summary>
    public class AlipayBossFncGfacceptanceBillAcceptResponse : AopResponse
    {
        /// <summary>
        /// 业财受理结果
        /// </summary>
        [XmlElement("result")]
        public GFAOpenAPIAcceptanceResult Result { get; set; }
    }
}
