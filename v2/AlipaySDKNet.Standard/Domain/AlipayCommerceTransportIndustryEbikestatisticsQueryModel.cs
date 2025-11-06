using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIndustryEbikestatisticsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportIndustryEbikestatisticsQueryModel : AopObject
    {
        /// <summary>
        /// 品牌编码，如雅迪传YD
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// query_type=month，入参date_str格式为yyyyMM； query_type=day，入参date_str格式为yyyyMMdd
        /// </summary>
        [XmlElement("date_str")]
        public string DateStr { get; set; }

        /// <summary>
        /// 页码，默认值1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小，默认值50
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询类型（month/day） month：查询月数据 day：查询日数据
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }
    }
}
