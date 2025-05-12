using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LivePlayRightDetail Data Structure.
    /// </summary>
    [Serializable]
    public class LivePlayRightDetail : AopObject
    {
        /// <summary>
        /// 跳转链接，用于领取成功之后的跳转
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 权益价值数，非金额，表示展示的权益数字
        /// </summary>
        [XmlElement("right_amount")]
        public string RightAmount { get; set; }

        /// <summary>
        /// 权益描述文案
        /// </summary>
        [XmlElement("right_desc_text")]
        public string RightDescText { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [XmlElement("right_name_text")]
        public string RightNameText { get; set; }

        /// <summary>
        /// 权益标题
        /// </summary>
        [XmlElement("right_title_text")]
        public string RightTitleText { get; set; }

        /// <summary>
        /// 权益单位
        /// </summary>
        [XmlElement("right_unit")]
        public string RightUnit { get; set; }
    }
}
