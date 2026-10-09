using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CampusInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CampusInfo : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 校区id
        /// </summary>
        [XmlElement("campus_id")]
        public string CampusId { get; set; }

        /// <summary>
        /// 校区名称
        /// </summary>
        [XmlElement("campus_name")]
        public string CampusName { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }
    }
}
