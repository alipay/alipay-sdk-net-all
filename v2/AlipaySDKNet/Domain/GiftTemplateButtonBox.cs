using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiftTemplateButtonBox Data Structure.
    /// </summary>
    [Serializable]
    public class GiftTemplateButtonBox : AopObject
    {
        /// <summary>
        /// 开红包按钮，用于拆红包页
        /// </summary>
        [XmlElement("button_url")]
        public string ButtonUrl { get; set; }

        /// <summary>
        /// 开红包按钮不可点击状态样式，用于”我的封面“列表页
        /// </summary>
        [XmlElement("invalid_button_url")]
        public string InvalidButtonUrl { get; set; }
    }
}
