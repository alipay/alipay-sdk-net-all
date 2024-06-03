using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ImageMsgVO Data Structure.
    /// </summary>
    [Serializable]
    public class ImageMsgVO : AopObject
    {
        /// <summary>
        /// 图片高度，请必须传图片真实的高度，否则客户端会按照填的宽高进行剪裁
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 图片文件id，请先通过图片上传接口上传图片<a href="https://opendocs.alipay.com/apis/036ros">https://opendocs.alipay.com/apis/036ros</a> 并获取到 file_id 作为这个入参的值
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 图片宽，请必须传图片真实的宽，否则客户端会按照填的宽高进行剪裁
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }
    }
}
