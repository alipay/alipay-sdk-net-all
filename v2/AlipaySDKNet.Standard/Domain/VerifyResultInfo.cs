using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VerifyResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VerifyResultInfo : AopObject
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
        /// 审核备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 场景code
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景描述
        /// </summary>
        [XmlElement("scene_desc")]
        public string SceneDesc { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 核验提示
        /// </summary>
        [XmlElement("verify_issue_desc")]
        public string VerifyIssueDesc { get; set; }

        /// <summary>
        /// 核验结果
        /// </summary>
        [XmlElement("verify_issue_type")]
        public string VerifyIssueType { get; set; }
    }
}
