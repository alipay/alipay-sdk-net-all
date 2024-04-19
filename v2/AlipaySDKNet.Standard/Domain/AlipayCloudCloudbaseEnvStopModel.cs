using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvStopModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseEnvStopModel : AopObject
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
    }
}
