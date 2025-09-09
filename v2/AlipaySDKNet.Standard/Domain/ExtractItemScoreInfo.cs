using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtractItemScoreInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExtractItemScoreInfo : AopObject
    {
        /// <summary>
        /// [{"code":"234","score":"99"}]
        /// </summary>
        [XmlArray("city_info_list")]
        [XmlArrayItem("geography_info")]
        public List<GeographyInfo> CityInfoList { get; set; }

        /// <summary>
        /// [{"code":"234","score":"99"}]
        /// </summary>
        [XmlArray("district_info_list")]
        [XmlArrayItem("geography_info")]
        public List<GeographyInfo> DistrictInfoList { get; set; }

        /// <summary>
        /// [{"name":"河南省人民医院","score":"99"}]
        /// </summary>
        [XmlArray("hos_info_list")]
        [XmlArrayItem("hos_info_info")]
        public List<HosInfoInfo> HosInfoList { get; set; }

        /// <summary>
        /// [{"code":"234","score":"99"}]
        /// </summary>
        [XmlArray("province_info_list")]
        [XmlArrayItem("geography_info")]
        public List<GeographyInfo> ProvinceInfoList { get; set; }

        /// <summary>
        /// [{"name":"骨科","score":"99"}]
        /// </summary>
        [XmlArray("univ_department_info_list")]
        [XmlArrayItem("hos_info_info")]
        public List<HosInfoInfo> UnivDepartmentInfoList { get; set; }
    }
}
