using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryCityResp Data Structure.
    /// </summary>
    [Serializable]
    public class QueryCityResp : AopObject
    {
        /// <summary>
        /// 城市编码（国标），用于后续站点/实时查询的 cityCode 入参。取值见本接口返回列表。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 该城市已开通的功能特性，用于判断可调用哪些能力（站点信息始终可查；实时/首末班车/拥挤度视城市而定）。
        /// </summary>
        [XmlElement("feature")]
        public FeatureVO Feature { get; set; }

        /// <summary>
        /// 城市中文名称。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
