using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RightDetailUrlInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RightDetailUrlInfo : AopObject
    {
        /// <summary>
        /// 是否有权益
        /// </summary>
        [XmlElement("has_right")]
        public bool HasRight { get; set; }

        /// <summary>
        /// 权益详情链接
        /// </summary>
        [XmlElement("right_detail_url")]
        public string RightDetailUrl { get; set; }
    }
}
