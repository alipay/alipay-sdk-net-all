using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceRegioninfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinDataserviceRegioninfoQueryModel : AopObject
    {
        /// <summary>
        /// 区域编码列表
        /// </summary>
        [XmlArray("region_codes")]
        [XmlArrayItem("string")]
        public List<string> RegionCodes { get; set; }

        /// <summary>
        /// 区域类型：PLOT / PROVINCE / CITY / COUNTY / TOWN
        /// </summary>
        [XmlElement("region_type")]
        public string RegionType { get; set; }
    }
}
