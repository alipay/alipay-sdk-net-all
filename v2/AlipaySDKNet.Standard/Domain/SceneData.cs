using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneData Data Structure.
    /// </summary>
    [Serializable]
    public class SceneData : AopObject
    {
        /// <summary>
        /// 该场景数据执行的环境
        /// </summary>
        [XmlElement("execute_env")]
        public string ExecuteEnv { get; set; }

        /// <summary>
        /// 场景明细数据
        /// </summary>
        [XmlArray("scene_data")]
        [XmlArrayItem("scene_data_unit")]
        public List<SceneDataUnit> SceneData_ { get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }
    }
}
