using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcDistrictQueryResponse.
    /// </summary>
    public class AlipayCommerceEcDistrictQueryResponse : AopResponse
    {
        /// <summary>
        /// 城市列表
        /// </summary>
        [XmlArray("city_list")]
        [XmlArrayItem("ec_area_info")]
        public List<EcAreaInfo> CityList { get; set; }

        /// <summary>
        /// 区列表
        /// </summary>
        [XmlArray("district_list")]
        [XmlArrayItem("ec_area_info")]
        public List<EcAreaInfo> DistrictList { get; set; }

        /// <summary>
        /// 省份列表
        /// </summary>
        [XmlArray("province_list")]
        [XmlArrayItem("ec_area_info")]
        public List<EcAreaInfo> ProvinceList { get; set; }
    }
}
