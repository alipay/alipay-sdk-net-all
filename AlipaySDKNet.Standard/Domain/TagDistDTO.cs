using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TagDistDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TagDistDTO : AopObject
    {
        /// <summary>
        /// 时间格式+不唯一
        /// </summary>
        [XmlElement("date_format")]
        public string DateFormat { get; set; }

        /// <summary>
        /// 展示名称+不唯一
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 最大值+不唯一
        /// </summary>
        [XmlElement("max")]
        public string Max { get; set; }

        /// <summary>
        /// 最小值+不唯一
        /// </summary>
        [XmlElement("mix")]
        public string Mix { get; set; }

        /// <summary>
        /// 展示值+不唯一
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
