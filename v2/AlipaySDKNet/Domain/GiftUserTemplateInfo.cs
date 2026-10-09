using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiftUserTemplateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GiftUserTemplateInfo : AopObject
    {
        /// <summary>
        /// 红包封面下半部分不带“开”字按钮的图片url
        /// </summary>
        [XmlElement("template_down_url")]
        public string TemplateDownUrl { get; set; }

        /// <summary>
        /// 封面缩略图url 图片宽高：400x560像素 图片格式：JPG 文件大小：≤100K
        /// </summary>
        [XmlElement("template_thumb_nail")]
        public string TemplateThumbNail { get; set; }

        /// <summary>
        /// 红包封面上半部分带“开”字按钮的图片url 图片宽高：600x864像素 图片格式：PNG 文件大小：≤150K
        /// </summary>
        [XmlElement("template_up_url")]
        public string TemplateUpUrl { get; set; }

        /// <summary>
        /// 封面是否在有效期内可被领取，true代表在有效期内，false代表不在有效期内
        /// </summary>
        [XmlElement("valid")]
        public string Valid { get; set; }

        /// <summary>
        /// 封面的有效期结束时间，is_valid==false时返回，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }

        /// <summary>
        /// 封面的有效期开始时间，当is_valid==true时返回，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("valid_start_time")]
        public string ValidStartTime { get; set; }
    }
}
