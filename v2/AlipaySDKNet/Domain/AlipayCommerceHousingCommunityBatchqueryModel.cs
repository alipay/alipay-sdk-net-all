using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingCommunityBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingCommunityBatchqueryModel : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 小区名称
        /// </summary>
        [XmlElement("community_name")]
        public string CommunityName { get; set; }

        /// <summary>
        /// 区县编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
