using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseExtensionRedisDestroyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseExtensionRedisDestroyResponse : AopResponse
    {
        /// <summary>
        /// 是否卸载成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
