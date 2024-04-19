using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubCheckLabel Data Structure.
    /// </summary>
    [Serializable]
    public class SubCheckLabel : AopObject
    {
        /// <summary>
        /// 机器审核内容的类型：0:图片内容,1:图片上的文字
        /// </summary>
        [XmlElement("hit_strategy")]
        public long HitStrategy { get; set; }

        /// <summary>
        /// 置信度分数：0-100之间取值，100为置信度最高，0为置信度最低
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 二级子分类，详细编码请与蚂蚁内容安全客户经理沟通获取
        /// </summary>
        [XmlElement("sub_label")]
        public string SubLabel { get; set; }
    }
}
