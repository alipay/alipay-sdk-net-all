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
        /// 券可以领取的过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 跳转链接，用于领取成功之后的跳转
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 1张。权益价值数，非金额，表示展示的权益数字，比如1张
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

        /// <summary>
        /// 券的价值(单位：元)
        /// </summary>
        [XmlElement("value_amount")]
        public string ValueAmount { get; set; }

        /// <summary>
        /// 券价值的单位
        /// </summary>
        [XmlElement("value_unit")]
        public string ValueUnit { get; set; }
    }
}
