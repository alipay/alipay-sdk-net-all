using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessDomainGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseHttpaccessDomainGetModel : AopObject
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
        /// 自定义域名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
