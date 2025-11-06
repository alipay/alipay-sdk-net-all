using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Userbase Data Structure.
    /// </summary>
    [Serializable]
    public class Userbase : AopObject
    {
        /// <summary>
        /// 出生日期
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 性别（男/女）
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 身高(cm)
        /// </summary>
        [XmlElement("height")]
        public string Height { get; set; }

        /// <summary>
        /// 参保类型（职工参保、居民参保）
        /// </summary>
        [XmlElement("insurance_type")]
        public string InsuranceType { get; set; }

        /// <summary>
        /// 居住地名称（省、市、区）
        /// </summary>
        [XmlElement("live_area_name")]
        public string LiveAreaName { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 体重(kg)
        /// </summary>
        [XmlElement("weight")]
        public string Weight { get; set; }
    }
}
