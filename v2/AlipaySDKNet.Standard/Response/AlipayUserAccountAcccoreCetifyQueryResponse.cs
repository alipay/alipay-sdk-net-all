using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAccountAcccoreCetifyQueryResponse.
    /// </summary>
    public class AlipayUserAccountAcccoreCetifyQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否已认证
        /// </summary>
        [XmlElement("certified")]
        public bool Certified { get; set; }
    }
}
