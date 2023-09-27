using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseExtensionMysqlDestroyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseExtensionMysqlDestroyResponse : AopResponse
    {
        /// <summary>
        /// 是否卸载成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
