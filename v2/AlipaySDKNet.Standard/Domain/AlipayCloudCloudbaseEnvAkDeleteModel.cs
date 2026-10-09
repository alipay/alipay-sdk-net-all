using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvAkDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseEnvAkDeleteModel : AopObject
    {
        /// <summary>
        /// ak
        /// </summary>
        [XmlElement("access_key_id")]
        public string AccessKeyId { get; set; }

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
    }
}
