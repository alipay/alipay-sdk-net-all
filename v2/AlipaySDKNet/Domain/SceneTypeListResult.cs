using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneTypeListResult Data Structure.
    /// </summary>
    [Serializable]
    public class SceneTypeListResult : AopObject
    {
        /// <summary>
        /// 场景类型信息
        /// </summary>
        [XmlArray("scene_type_list")]
        [XmlArrayItem("scene_type_v_o")]
        public List<SceneTypeVO> SceneTypeList { get; set; }
    }
}
