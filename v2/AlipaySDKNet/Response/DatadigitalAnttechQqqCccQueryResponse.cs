using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAnttechQqqCccQueryResponse.
    /// </summary>
    public class DatadigitalAnttechQqqCccQueryResponse : AopResponse
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlArray("city_code_open_id")]
        [XmlArrayItem("string")]
        public List<string> CityCodeOpenId { get; set; }

        /// <summary>
        /// dgf
        /// </summary>
        [XmlElement("city_cppp_open_id")]
        public string CityCpppOpenId { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province_code_open_id")]
        public string ProvinceCodeOpenId { get; set; }
    }
}
