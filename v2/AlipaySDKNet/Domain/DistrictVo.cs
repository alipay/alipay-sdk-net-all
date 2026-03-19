using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DistrictVo Data Structure.
    /// </summary>
    [Serializable]
    public class DistrictVo : AopObject
    {
        /// <summary>
        /// 区县编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 区县名称
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }
    }
}
