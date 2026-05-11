using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransSceneQueryResponse.
    /// </summary>
    public class AlipayFundTransSceneQueryResponse : AopResponse
    {
        /// <summary>
        /// 场景信息列表
        /// </summary>
        [XmlArray("scene_info_list")]
        [XmlArrayItem("scene_apply_record")]
        public List<SceneApplyRecord> SceneInfoList { get; set; }
    }
}
