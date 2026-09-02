using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryReferralJobBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryReferralJobBatchqueryModel : AopObject
    {
        /// <summary>
        /// 城市区县编码，六位精确匹配
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 距离过滤范围，单位：米，最远10km
        /// </summary>
        [XmlElement("distance_range")]
        public long DistanceRange { get; set; }

        /// <summary>
        /// 高德系纬度，经纬度和城市编码同时不传不返回数据
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 高德系经度，配合latitude和distance_range做距离过滤
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 页码，默认1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量，默认10，最大20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 推荐官注册后获取的ID
        /// </summary>
        [XmlElement("recommender_id")]
        public string RecommenderId { get; set; }
    }
}
