using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpscerthostingDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseHttpscerthostingDeleteModel : AopObject
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

        /// <summary>
        /// https证书ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
