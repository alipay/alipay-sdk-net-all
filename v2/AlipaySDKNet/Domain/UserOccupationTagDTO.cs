using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserOccupationTagDTO Data Structure.
    /// </summary>
    [Serializable]
    public class UserOccupationTagDTO : AopObject
    {
        /// <summary>
        /// 用户职业占比
        /// </summary>
        [XmlElement("ratio")]
        public string Ratio { get; set; }

        /// <summary>
        /// 用户职业标签值
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }
    }
}
