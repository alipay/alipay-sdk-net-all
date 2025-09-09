using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupMsgAutoreplyActionConfigVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupMsgAutoreplyActionConfigVO : AopObject
    {
        /// <summary>
        /// 图片文件id，请先通过图片上传接口上传图片<a href="https://opendocs.alipay.com/apis/036ros">https://opendocs.alipay.com/apis/036ros</a> 并获取到 file_id 作为这个入参的值
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 消息跳转地址，输入alipays:// 或者 https://的链接
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 链接描述
        /// </summary>
        [XmlElement("link_desc")]
        public string LinkDesc { get; set; }

        /// <summary>
        /// 图片文件id，请先通过图片上传接口上传图片<a href="https://opendocs.alipay.com/apis/036ros">https://opendocs.alipay.com/apis/036ros</a> 并获取到 file_id 作为这个入参的值
        /// </summary>
        [XmlElement("link_image_id")]
        public string LinkImageId { get; set; }

        /// <summary>
        /// 链接标题
        /// </summary>
        [XmlElement("link_title")]
        public string LinkTitle { get; set; }

        /// <summary>
        /// 回复消息类型
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 文本回复内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
