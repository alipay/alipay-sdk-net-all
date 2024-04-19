using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseLayerVersionGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseLayerVersionGetModel : AopObject
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
        /// 层名称
        /// </summary>
        [XmlElement("layer_name")]
        public string LayerName { get; set; }

        /// <summary>
        /// 层版本名称
        /// </summary>
        [XmlElement("layer_version_name")]
        public string LayerVersionName { get; set; }
    }
}
