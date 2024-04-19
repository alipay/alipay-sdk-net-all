using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseLayerVersionQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseLayerVersionQueryResponse : AopResponse
    {
        /// <summary>
        /// 镜像列表
        /// </summary>
        [XmlArray("layer_versions")]
        [XmlArrayItem("layer_version")]
        public List<LayerVersion> LayerVersions { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
