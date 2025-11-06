using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTagVO Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTagVO : AopObject
    {
        /// <summary>
        /// 标签唯一ID
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 图片相册值
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }
    }
}
