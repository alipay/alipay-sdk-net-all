using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceRegionSimpleVO Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceRegionSimpleVO : AopObject
    {
        /// <summary>
        /// 区域码
        /// </summary>
        [XmlElement("region_code")]
        public string RegionCode { get; set; }

        /// <summary>
        /// 0=全球 1=国家 2=省 3=市 4=区县 5=乡镇街道 9=自定义 601=小区poi
        /// </summary>
        [XmlElement("region_type")]
        public string RegionType { get; set; }
    }
}
