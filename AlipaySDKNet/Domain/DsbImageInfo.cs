using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DsbImageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DsbImageInfo : AopObject
    {
        /// <summary>
        /// 定损图片的afts id
        /// </summary>
        [XmlElement("afts_id")]
        public string AftsId { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        [XmlElement("image_name")]
        public string ImageName { get; set; }

        /// <summary>
        /// 拍摄时间
        /// </summary>
        [XmlElement("shoot_time")]
        public string ShootTime { get; set; }
    }
}
