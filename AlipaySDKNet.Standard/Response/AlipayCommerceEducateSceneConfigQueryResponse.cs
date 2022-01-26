using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSceneConfigQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSceneConfigQueryResponse : AopResponse
    {
        /// <summary>
        /// 一脸通行服务配置信息查询结果
        /// </summary>
        [XmlArray("scene_config_infos")]
        [XmlArrayItem("scene_config_query_d_t_o")]
        public List<SceneConfigQueryDTO> SceneConfigInfos { get; set; }
    }
}
