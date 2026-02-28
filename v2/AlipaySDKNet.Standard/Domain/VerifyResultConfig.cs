using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VerifyResultConfig Data Structure.
    /// </summary>
    [Serializable]
    public class VerifyResultConfig : AopObject
    {
        /// <summary>
        /// 点击跳转地址
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

        /// <summary>
        /// 核验提示类型
        /// </summary>
        [XmlElement("verify_issue_type")]
        public string VerifyIssueType { get; set; }
    }
}
