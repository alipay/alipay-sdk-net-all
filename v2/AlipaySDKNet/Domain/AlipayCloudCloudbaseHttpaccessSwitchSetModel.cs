using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessSwitchSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseHttpaccessSwitchSetModel : AopObject
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
        /// HTTP访问开关状态
        /// </summary>
        [XmlElement("enabled")]
        public bool Enabled { get; set; }
    }
}
