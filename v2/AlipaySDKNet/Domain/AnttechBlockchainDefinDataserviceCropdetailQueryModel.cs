using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceCropdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinDataserviceCropdetailQueryModel : AopObject
    {
        /// <summary>
        /// 产品类型，根据定义多期的产品类型进行输入，1002/1005/1006/1007/1008/1010/1011
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 区域编码
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
