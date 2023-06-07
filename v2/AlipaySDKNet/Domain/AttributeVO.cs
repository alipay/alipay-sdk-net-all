using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AttributeVO Data Structure.
    /// </summary>
    [Serializable]
    public class AttributeVO : AopObject
    {
        /// <summary>
        /// 是否必填属性
        /// </summary>
        [XmlElement("is_required")]
        public bool IsRequired { get; set; }

        /// <summary>
        /// 属性key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 属性值长度区间,上下限,分隔,属性组件类型是input时可用
        /// </summary>
        [XmlElement("length")]
        public string Length { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 属性值范围区间,上下限,分隔,属性组件类型是number_picker时可用
        /// </summary>
        [XmlElement("range")]
        public string Range { get; set; }

        /// <summary>
        /// 属性组件类型,文本输入框:input,单选框:select_one,数值输入框:number_picker
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 属性值枚举,多值;分隔
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
