using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseExtensionRedisApplyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseExtensionRedisApplyResponse : AopResponse
    {
        /// <summary>
        /// 是否已成功开始安装
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
