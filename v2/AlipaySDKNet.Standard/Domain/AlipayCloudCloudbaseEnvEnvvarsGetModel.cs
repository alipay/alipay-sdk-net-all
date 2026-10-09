using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvEnvvarsGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseEnvEnvvarsGetModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境ID
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }
    }
}
