using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseLayerGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseLayerGetResponse : AopResponse
    {
        /// <summary>
        /// 层描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 最新层版本名称
        /// </summary>
        [XmlElement("latest_layer_version_name")]
        public string LatestLayerVersionName { get; set; }

        /// <summary>
        /// 层名称
        /// </summary>
        [XmlElement("layer_name")]
        public string LayerName { get; set; }
    }
}
