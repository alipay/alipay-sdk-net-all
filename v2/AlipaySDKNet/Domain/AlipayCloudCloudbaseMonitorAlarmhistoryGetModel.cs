using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorAlarmhistoryGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseMonitorAlarmhistoryGetModel : AopObject
    {
        /// <summary>
        /// 小程序云app ID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 小程序云环境ID
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 报警历史id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
