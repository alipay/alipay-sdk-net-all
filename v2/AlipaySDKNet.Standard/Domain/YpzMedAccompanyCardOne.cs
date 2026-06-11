using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YpzMedAccompanyCardOne Data Structure.
    /// </summary>
    [Serializable]
    public class YpzMedAccompanyCardOne : AopObject
    {
        /// <summary>
        /// 陪诊师名字
        /// </summary>
        [XmlElement("attendant_name")]
        public string AttendantName { get; set; }

        /// <summary>
        /// 主按钮url
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 左按钮url
        /// </summary>
        [XmlElement("redirect_url_left")]
        public string RedirectUrlLeft { get; set; }

        /// <summary>
        /// 右按钮url
        /// </summary>
        [XmlElement("redirect_url_right")]
        public string RedirectUrlRight { get; set; }

        /// <summary>
        /// 卡片状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
