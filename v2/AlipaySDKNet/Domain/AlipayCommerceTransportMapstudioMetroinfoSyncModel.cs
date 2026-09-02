using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportMapstudioMetroinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportMapstudioMetroinfoSyncModel : AopObject
    {
        /// <summary>
        /// 城市区域编码，例如南京：320100
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 地铁基础信息
        /// </summary>
        [XmlArray("metro_info_details")]
        [XmlArrayItem("metro_info_object")]
        public List<MetroInfoObject> MetroInfoDetails { get; set; }

        /// <summary>
        /// 地铁月份，格式 YYYYMM，如 "202509"
        /// </summary>
        [XmlElement("metro_month")]
        public string MetroMonth { get; set; }
    }
}
