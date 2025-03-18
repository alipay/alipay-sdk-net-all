using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTourPoiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTourPoiQueryModel : AopObject
    {
        /// <summary>
        /// 城市市区编码，用于查询匹配信息
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市区域编码，用于查询匹配信息
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 页码值，用于信息分页
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 页面大小，用于信息分页
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 点位名称，用于查询对应点位信息，支持模糊匹配
        /// </summary>
        [XmlElement("poim_name")]
        public string PoimName { get; set; }

        /// <summary>
        /// 城市省编码，用于查询匹配信息
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
