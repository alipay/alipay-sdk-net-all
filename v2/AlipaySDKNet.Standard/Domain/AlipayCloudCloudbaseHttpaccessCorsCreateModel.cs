using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessCorsCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseHttpaccessCorsCreateModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 允许跨域的域名
        /// </summary>
        [XmlElement("domain_name")]
        public string DomainName { get; set; }
    }
}
