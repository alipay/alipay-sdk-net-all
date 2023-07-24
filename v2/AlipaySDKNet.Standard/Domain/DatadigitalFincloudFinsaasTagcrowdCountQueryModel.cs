using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasTagcrowdCountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasTagcrowdCountQueryModel : AopObject
    {
        /// <summary>
        /// 标签组规则列表+不唯一
        /// </summary>
        [XmlArray("rules")]
        [XmlArrayItem("tag_rule_group_d_t_o")]
        public List<TagRuleGroupDTO> Rules { get; set; }

        /// <summary>
        /// 场景编码+唯一 当前字段已废弃(迁移图灵平台后，预估人群数API不需要传递sceneCode)
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
