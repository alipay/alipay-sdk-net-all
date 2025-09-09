using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpscerthostingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseHttpscerthostingQueryModel : AopObject
    {
        /// <summary>
        /// 小程序云应用ID
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
