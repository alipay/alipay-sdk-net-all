using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionLayerQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionLayerQueryResponse : AopResponse
    {
        /// <summary>
        /// 绑定层列表
        /// </summary>
        [XmlArray("layers")]
        [XmlArrayItem("layer_info")]
        public List<LayerInfo> Layers { get; set; }
    }
}
