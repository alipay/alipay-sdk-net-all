using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceCropbaseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinDataserviceCropbaseQueryModel : AopObject
    {
        /// <summary>
        /// 区域编码，省市区镇四级编码或区块ID
        /// </summary>
        [XmlElement("region_code")]
        public string RegionCode { get; set; }

        /// <summary>
        /// 区域类型，PLOT/PROVINCE/CITY/COUNTY/TOWN
        /// </summary>
        [XmlElement("region_type")]
        public string RegionType { get; set; }
    }
}
