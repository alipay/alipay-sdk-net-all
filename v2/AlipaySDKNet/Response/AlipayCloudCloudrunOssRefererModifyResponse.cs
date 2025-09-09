using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunOssRefererModifyResponse.
    /// </summary>
    public class AlipayCloudCloudrunOssRefererModifyResponse : AopResponse
    {
        /// <summary>
        /// referer配置
        /// </summary>
        [XmlElement("referer")]
        public RefererSetting Referer { get; set; }
    }
}
