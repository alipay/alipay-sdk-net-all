using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TimeStampRectOpenVO Data Structure.
    /// </summary>
    [Serializable]
    public class TimeStampRectOpenVO : AopObject
    {
        /// <summary>
        /// X轴偏移量，相对当前页左下角原点的X轴偏移量，非负数值，最大取值497，由用户输入，请注意取值范围。
        /// </summary>
        [XmlElement("offset_x")]
        public long OffsetX { get; set; }

        /// <summary>
        /// Y轴偏移量，相对当前页左下角原点的Y轴偏移量，非负数值，最大取值744，由用户输入，请注意取值范围。
        /// </summary>
        [XmlElement("offset_y")]
        public long OffsetY { get; set; }

        /// <summary>
        /// 组件所属页，页从1开始，由用户传入。
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 组件ID，当前合同模板所有组件中唯一值，由用户传入。
        /// </summary>
        [XmlElement("rect_id")]
        public string RectId { get; set; }

        /// <summary>
        /// 组件名称，非唯一值，由用户传入。
        /// </summary>
        [XmlElement("rect_name")]
        public string RectName { get; set; }

        /// <summary>
        /// 组件样式，非必填，含有默认值。
        /// </summary>
        [XmlElement("rect_style")]
        public SignatoryStyle RectStyle { get; set; }

        /// <summary>
        /// 企业章组件内是否必须签章，默认为true.
        /// </summary>
        [XmlElement("required")]
        public bool Required { get; set; }

        /// <summary>
        /// 时间格式展示，例如"yyyy-MM-dd"。
        /// </summary>
        [XmlElement("time_format")]
        public string TimeFormat { get; set; }
    }
}
