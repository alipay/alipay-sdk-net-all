using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserGenderTagDTO Data Structure.
    /// </summary>
    [Serializable]
    public class UserGenderTagDTO : AopObject
    {
        /// <summary>
        /// 用户性别占比
        /// </summary>
        [XmlElement("ratio")]
        public string Ratio { get; set; }

        /// <summary>
        /// 用户性别标签值
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }
    }
}
