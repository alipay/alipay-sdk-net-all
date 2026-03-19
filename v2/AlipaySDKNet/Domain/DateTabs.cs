using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DateTabs Data Structure.
    /// </summary>
    [Serializable]
    public class DateTabs : AopObject
    {
        /// <summary>
        /// x坐标，单位点（point）
        /// </summary>
        [XmlElement("axis_x")]
        public long AxisX { get; set; }

        /// <summary>
        /// y坐标，单位点（point）
        /// </summary>
        [XmlElement("axis_y")]
        public long AxisY { get; set; }

        /// <summary>
        /// 字体颜色
        /// </summary>
        [XmlElement("color")]
        public string Color { get; set; }

        /// <summary>
        /// 字体大小，默认50，单位点（point）
        /// </summary>
        [XmlElement("font_size")]
        public long FontSize { get; set; }

        /// <summary>
        /// 是否使用日期组件
        /// </summary>
        [XmlElement("use_date_tab")]
        public bool UseDateTab { get; set; }
    }
}
