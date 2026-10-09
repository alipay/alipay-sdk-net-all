using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IcpDistrictAreaItemList Data Structure.
    /// </summary>
    [Serializable]
    public class IcpDistrictAreaItemList : AopObject
    {
        /// <summary>
        /// 东城区
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 地区中文名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
