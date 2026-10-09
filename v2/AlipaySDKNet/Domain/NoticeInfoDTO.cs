using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NoticeInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class NoticeInfoDTO : AopObject
    {
        /// <summary>
        /// 须知内容
        /// </summary>
        [XmlElement("notice_content")]
        public string NoticeContent { get; set; }

        /// <summary>
        /// 须知图片地址
        /// </summary>
        [XmlElement("notice_pic_url")]
        public string NoticePicUrl { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
