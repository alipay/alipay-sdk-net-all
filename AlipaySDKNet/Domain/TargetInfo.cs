using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TargetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TargetInfo : AopObject
    {
        /// <summary>
        /// 应用id，例如小程序id
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 应用类型 小程序传入：APPID 生活号传入：PUBLICID
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
