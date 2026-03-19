using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrafficCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TrafficCardInfo : AopObject
    {
        /// <summary>
        /// 乘车卡标题
        /// </summary>
        [XmlElement("card_title")]
        public string CardTitle { get; set; }

        /// <summary>
        /// 乘车卡跳转链接
        /// </summary>
        [XmlElement("card_use_url")]
        public string CardUseUrl { get; set; }

        /// <summary>
        /// 卡面图片链接
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 乘车卡业主logo链接
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }
    }
}
