using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportMapstudioRouteinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportMapstudioRouteinfoSyncModel : AopObject
    {
        /// <summary>
        /// 城市区域编码，例如：南京320100
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 线路相关信息
        /// </summary>
        [XmlArray("route_info_details")]
        [XmlArrayItem("route_info_object")]
        public List<RouteInfoObject> RouteInfoDetails { get; set; }

        /// <summary>
        /// 线路打分月份，格式 YYYYMM，如 "202509"
        /// </summary>
        [XmlElement("route_score_month")]
        public string RouteScoreMonth { get; set; }
    }
}
