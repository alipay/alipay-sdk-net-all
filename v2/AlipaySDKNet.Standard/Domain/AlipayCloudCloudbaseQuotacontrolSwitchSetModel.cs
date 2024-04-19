using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseQuotacontrolSwitchSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseQuotacontrolSwitchSetModel : AopObject
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
        /// 额度防控开关状态
        /// </summary>
        [XmlElement("enable")]
        public bool Enable { get; set; }
    }
}
