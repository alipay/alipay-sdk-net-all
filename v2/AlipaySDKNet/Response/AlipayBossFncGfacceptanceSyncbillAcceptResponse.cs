using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfacceptanceSyncbillAcceptResponse.
    /// </summary>
    public class AlipayBossFncGfacceptanceSyncbillAcceptResponse : AopResponse
    {
        /// <summary>
        /// 业财受理结果
        /// </summary>
        [XmlElement("result")]
        public GFAOpenAPIAcceptanceResult Result { get; set; }
    }
}
