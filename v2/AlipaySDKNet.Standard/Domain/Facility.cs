using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Facility Data Structure.
    /// </summary>
    [Serializable]
    public class Facility : AopObject
    {
        /// <summary>
        /// 设施种类
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 设施种类名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 设施名称
        /// </summary>
        [XmlElement("facility_name")]
        public string FacilityName { get; set; }
    }
}
