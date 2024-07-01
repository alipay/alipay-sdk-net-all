using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LayerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LayerInfo : AopObject
    {
        /// <summary>
        /// 层描述
        /// </summary>
        [XmlElement("layer_description")]
        public string LayerDescription { get; set; }

        /// <summary>
        /// 层显示名称
        /// </summary>
        [XmlElement("layer_display_name")]
        public string LayerDisplayName { get; set; }

        /// <summary>
        /// 层名称
        /// </summary>
        [XmlElement("layer_name")]
        public string LayerName { get; set; }

        /// <summary>
        /// 层版本描述
        /// </summary>
        [XmlElement("layer_version_description")]
        public string LayerVersionDescription { get; set; }

        /// <summary>
        /// 层版本中文名
        /// </summary>
        [XmlElement("layer_version_display_name")]
        public string LayerVersionDisplayName { get; set; }

        /// <summary>
        /// 层版本镜像列表中文名称
        /// </summary>
        [XmlArray("layer_version_image_display_names")]
        [XmlArrayItem("string")]
        public List<string> LayerVersionImageDisplayNames { get; set; }

        /// <summary>
        /// 层版本镜像列表
        /// </summary>
        [XmlArray("layer_version_image_list")]
        [XmlArrayItem("string")]
        public List<string> LayerVersionImageList { get; set; }

        /// <summary>
        /// 层版本名称
        /// </summary>
        [XmlElement("layer_version_name")]
        public string LayerVersionName { get; set; }
    }
}
