using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseRedisCapacityModifyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseRedisCapacityModifyResponse : AopResponse
    {
        /// <summary>
        /// 扩缩容结果
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
