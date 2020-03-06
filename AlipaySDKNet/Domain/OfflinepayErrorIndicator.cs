using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OfflinepayErrorIndicator Data Structure.
    /// </summary>
    [Serializable]
    public class OfflinepayErrorIndicator : AopObject
    {
        /// <summary>
        /// 右动作按钮
        /// </summary>
        [XmlElement("action_button")]
        public string ActionButton { get; set; }

        /// <summary>
        /// 右动作按钮跳转地址
        /// </summary>
        [XmlElement("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 针对alipayinside的定制化提示文案
        /// </summary>
        [XmlElement("alipay_inside_tips")]
        public string AlipayInsideTips { get; set; }

        /// <summary>
        /// 是否清楚卡片本地缓存
        /// </summary>
        [XmlElement("clean_card")]
        public bool CleanCard { get; set; }

        /// <summary>
        /// 左动作按钮
        /// </summary>
        [XmlElement("default_button")]
        public string DefaultButton { get; set; }

        /// <summary>
        /// 默认跳转地址
        /// </summary>
        [XmlElement("default_url")]
        public string DefaultUrl { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 错误码值
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误提示文案
        /// </summary>
        [XmlElement("tips")]
        public string Tips { get; set; }

        /// <summary>
        /// 客户端提示类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
