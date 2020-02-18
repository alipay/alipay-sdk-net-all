using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserIdenticalAuthbaseQueryResponse.
    /// </summary>
    public class AlipayUserIdenticalAuthbaseQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否是同人账号
        /// </summary>
        [XmlElement("identical")]
        public bool Identical { get; set; }
    }
}
