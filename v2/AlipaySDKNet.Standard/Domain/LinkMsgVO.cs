using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LinkMsgVO Data Structure.
    /// </summary>
    [Serializable]
    public class LinkMsgVO : AopObject
    {
        /// <summary>
        /// 消息描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 图片文件id，请先通过图片上传接口上传图片<a href="https://opendocs.alipay.com/apis/036ros">https://opendocs.alipay.com/apis/036ros</a>并获取到 file_id 作为这个入参的值
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 消息标题，c侧消息展示的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 消息跳转地址，输入alipays:// 或者 https://的链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
