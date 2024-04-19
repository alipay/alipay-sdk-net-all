using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseIdeConfigGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseIdeConfigGetModel : AopObject
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
        /// 密钥超时时长(分钟)
        /// </summary>
        [XmlElement("key_expire_time")]
        public long KeyExpireTime { get; set; }
    }
}
