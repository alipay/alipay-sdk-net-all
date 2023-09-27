using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseExtensionBsnDestroyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseExtensionBsnDestroyResponse : AopResponse
    {
        /// <summary>
        /// 是否卸载成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
