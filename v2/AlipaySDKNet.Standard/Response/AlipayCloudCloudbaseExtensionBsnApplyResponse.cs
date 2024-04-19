using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseExtensionBsnApplyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseExtensionBsnApplyResponse : AopResponse
    {
        /// <summary>
        /// 是否已成功开始安装
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
