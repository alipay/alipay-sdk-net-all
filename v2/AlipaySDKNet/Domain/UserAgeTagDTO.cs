using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserAgeTagDTO Data Structure.
    /// </summary>
    [Serializable]
    public class UserAgeTagDTO : AopObject
    {
        /// <summary>
        /// 用户年龄段占比
        /// </summary>
        [XmlElement("ratio")]
        public string Ratio { get; set; }

        /// <summary>
        /// 用户年龄标签值
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }
    }
}
