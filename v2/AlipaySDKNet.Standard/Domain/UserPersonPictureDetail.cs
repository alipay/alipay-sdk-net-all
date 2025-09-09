using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserPersonPictureDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UserPersonPictureDetail : AopObject
    {
        /// <summary>
        /// 用户证件图片字节流对应的Base64数据,没有携带Data URL前缀
        /// </summary>
        [XmlElement("picture_data")]
        public string PictureData { get; set; }

        /// <summary>
        /// 用户证件图片链接
        /// </summary>
        [XmlElement("picture_url")]
        public string PictureUrl { get; set; }
    }
}
