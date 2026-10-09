using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsUnderwritePolicyQueryResponse.
    /// </summary>
    public class AlipayInsUnderwritePolicyQueryResponse : AopResponse
    {
        /// <summary>
        /// 保单
        /// </summary>
        [XmlElement("policy")]
        public InsPolicy Policy { get; set; }
    }
}
