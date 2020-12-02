using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppApiSceneQueryResponse.
    /// </summary>
    public class AlipayOpenAppApiSceneQueryResponse : AopResponse
    {
        /// <summary>
        /// 接口信息字段应用场景
        /// </summary>
        [XmlArray("auth_field_scene")]
        [XmlArrayItem("auth_field_scene_d_t_o")]
        public List<AuthFieldSceneDTO> AuthFieldScene { get; set; }
    }
}
