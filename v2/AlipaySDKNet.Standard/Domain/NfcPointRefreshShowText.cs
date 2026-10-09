using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NfcPointRefreshShowText Data Structure.
    /// </summary>
    [Serializable]
    public class NfcPointRefreshShowText : AopObject
    {
        /// <summary>
        /// 底部小字文案
        /// </summary>
        [XmlElement("bottom_text")]
        public string BottomText { get; set; }

        /// <summary>
        /// 中央核心文案
        /// </summary>
        [XmlElement("middle_smart_text")]
        public string MiddleSmartText { get; set; }

        /// <summary>
        /// 顶部标题文案
        /// </summary>
        [XmlElement("title_text")]
        public string TitleText { get; set; }
    }
}
