using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeSceneQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeSceneQueryResponse : AopResponse
    {
        /// <summary>
        /// 场景信息列表
        /// </summary>
        [XmlArray("scene_info_list")]
        [XmlArrayItem("ampe_scene_response")]
        public List<AmpeSceneResponse> SceneInfoList { get; set; }
    }
}
