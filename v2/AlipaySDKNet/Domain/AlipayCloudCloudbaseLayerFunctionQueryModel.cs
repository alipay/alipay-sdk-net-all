using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseLayerFunctionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseLayerFunctionQueryModel : AopObject
    {
        /// <summary>
        /// 小程序云AppID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 小程序云环境ID
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
