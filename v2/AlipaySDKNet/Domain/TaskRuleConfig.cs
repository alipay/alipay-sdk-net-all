using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskRuleConfig Data Structure.
    /// </summary>
    [Serializable]
    public class TaskRuleConfig : AopObject
    {
        /// <summary>
        /// 商品配置列表
        /// </summary>
        [XmlArray("good_list")]
        [XmlArrayItem("task_good_config")]
        public List<TaskGoodConfig> GoodList { get; set; }

        /// <summary>
        /// 任务场景标签列表。场景枚举值：home_delivery（外卖）
        /// </summary>
        [XmlArray("scene_tag_list")]
        [XmlArrayItem("string")]
        public List<string> SceneTagList { get; set; }
    }
}
