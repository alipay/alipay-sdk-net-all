using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseLayerVersionUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseLayerVersionUploadModel : AopObject
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
        /// 版本描述
        /// </summary>
        [XmlElement("version_description")]
        public string VersionDescription { get; set; }

        /// <summary>
        /// 镜像列表
        /// </summary>
        [XmlArray("version_image_list")]
        [XmlArrayItem("string")]
        public List<string> VersionImageList { get; set; }

        /// <summary>
        /// 版本名称
        /// </summary>
        [XmlElement("version_name")]
        public string VersionName { get; set; }
    }
}
