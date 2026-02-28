using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VerifyConfigResultPageConfig Data Structure.
    /// </summary>
    [Serializable]
    public class VerifyConfigResultPageConfig : AopObject
    {
        /// <summary>
        /// 按钮跳转类型
        /// </summary>
        [XmlElement("button_jump_type")]
        public string ButtonJumpType { get; set; }

        /// <summary>
        /// 按钮跳转地址
        /// </summary>
        [XmlElement("button_jump_url")]
        public string ButtonJumpUrl { get; set; }

        /// <summary>
        /// 按钮文案
        /// </summary>
        [XmlElement("button_text")]
        public string ButtonText { get; set; }

        /// <summary>
        /// 主标题
        /// </summary>
        [XmlElement("main_title")]
        public string MainTitle { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }
    }
}
