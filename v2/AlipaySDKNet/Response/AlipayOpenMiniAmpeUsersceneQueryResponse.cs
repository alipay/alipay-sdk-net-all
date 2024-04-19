using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeUsersceneQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeUsersceneQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户未选择的场景列表
        /// </summary>
        [XmlElement("disable_scene_info_list")]
        public AmpeSceneResponse DisableSceneInfoList { get; set; }

        /// <summary>
        /// 用户已经选择的场景列表
        /// </summary>
        [XmlArray("enable_scene_info_list")]
        [XmlArrayItem("ampe_scene_response")]
        public List<AmpeSceneResponse> EnableSceneInfoList { get; set; }
    }
}
