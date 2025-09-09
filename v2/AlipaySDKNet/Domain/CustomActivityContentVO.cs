using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomActivityContentVO Data Structure.
    /// </summary>
    [Serializable]
    public class CustomActivityContentVO : AopObject
    {
        /// <summary>
        /// 活动跳转行动点
        /// </summary>
        [XmlElement("action_name")]
        public string ActionName { get; set; }

        /// <summary>
        /// 活动跳转地址
        /// </summary>
        [XmlElement("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 活动描述，可以不填
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 图片文件id，支持的图片 jpg、jpeg、png，宽高1:1，大小小于2M，请先通过图片上传接口上传图片<a href="https://opendocs.alipay.com/apis/036ros">https://opendocs.alipay.com/apis/036ros</a>并获取到 file_id 作为这个入参的值
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 活动标题，展示在c端商家群活动的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
