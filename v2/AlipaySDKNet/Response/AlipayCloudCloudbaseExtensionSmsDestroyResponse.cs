using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseExtensionSmsDestroyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseExtensionSmsDestroyResponse : AopResponse
    {
        /// <summary>
        /// 是否卸载成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
