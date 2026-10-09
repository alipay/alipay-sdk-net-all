using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemSceneRiskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemSceneRiskInfo : AopObject
    {
        /// <summary>
        /// 具体问题描述
        /// </summary>
        [XmlArray("risk_infos")]
        [XmlArrayItem("reasons")]
        public List<Reasons> RiskInfos { get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
