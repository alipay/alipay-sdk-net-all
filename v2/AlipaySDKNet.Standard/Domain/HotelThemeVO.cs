using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HotelThemeVO Data Structure.
    /// </summary>
    [Serializable]
    public class HotelThemeVO : AopObject
    {
        /// <summary>
        /// 背景颜色
        /// </summary>
        [XmlElement("hotelmind_bg")]
        public string HotelmindBg { get; set; }

        /// <summary>
        /// 主按钮文字颜色
        /// </summary>
        [XmlElement("hotelmind_btn_text")]
        public string HotelmindBtnText { get; set; }

        /// <summary>
        /// 标题文字颜色、按钮文字颜色、边框颜色、主按钮颜色
        /// </summary>
        [XmlElement("hotelmind_title")]
        public string HotelmindTitle { get; set; }

        /// <summary>
        /// 智能体形象图片链接
        /// </summary>
        [XmlElement("person_logo")]
        public string PersonLogo { get; set; }
    }
}
