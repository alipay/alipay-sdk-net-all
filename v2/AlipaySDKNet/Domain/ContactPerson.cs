using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContactPerson Data Structure.
    /// </summary>
    [Serializable]
    public class ContactPerson : AopObject
    {
        /// <summary>
        /// 联系方式列表
        /// </summary>
        [XmlArray("contact_ways")]
        [XmlArrayItem("contact_way_info")]
        public List<ContactWayInfo> ContactWays { get; set; }

        /// <summary>
        /// 店铺联系人的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
