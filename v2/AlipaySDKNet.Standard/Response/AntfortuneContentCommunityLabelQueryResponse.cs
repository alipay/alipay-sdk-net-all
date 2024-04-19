using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneContentCommunityLabelQueryResponse.
    /// </summary>
    public class AntfortuneContentCommunityLabelQueryResponse : AopResponse
    {
        /// <summary>
        /// groupKey：标签组key groupName 标签组名字
        /// </summary>
        [XmlElement("label_group_list")]
        public string LabelGroupList { get; set; }

        /// <summary>
        /// 场景key
        /// </summary>
        [XmlElement("scene_key")]
        public string SceneKey { get; set; }

        /// <summary>
        /// 场景名字
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }
    }
}
