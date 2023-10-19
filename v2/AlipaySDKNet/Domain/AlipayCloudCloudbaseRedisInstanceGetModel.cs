using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseRedisInstanceGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseRedisInstanceGetModel : AopObject
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
        /// Redis实例ID
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }
    }
}
