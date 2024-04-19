using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseLayerVersionGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseLayerVersionGetResponse : AopResponse
    {
        /// <summary>
        /// 版本描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 版本中文名
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 是否能够删除
        /// </summary>
        [XmlElement("enable_delete")]
        public bool EnableDelete { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 镜像列表中文名称
        /// </summary>
        [XmlArray("image_display_names")]
        [XmlArrayItem("string")]
        public List<string> ImageDisplayNames { get; set; }

        /// <summary>
        /// 镜像列表
        /// </summary>
        [XmlArray("image_list")]
        [XmlArrayItem("string")]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// 层名称
        /// </summary>
        [XmlElement("layer_name")]
        public string LayerName { get; set; }

        /// <summary>
        /// 版本名称
        /// </summary>
        [XmlElement("layer_version_name")]
        public string LayerVersionName { get; set; }
    }
}
