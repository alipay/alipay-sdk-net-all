using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportMetroStationQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportMetroStationQueryResponse : AopResponse
    {
        /// <summary>
        /// 经纬度信息
        /// </summary>
        [XmlElement("lbs")]
        public LbsVO Lbs { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("lines")]
        [XmlArrayItem("line_v_o")]
        public List<LineVO> Lines { get; set; }

        /// <summary>
        /// 乘车码链接
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 站点code
        /// </summary>
        [XmlElement("station_code")]
        public string StationCode { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("station_name")]
        public string StationName { get; set; }
    }
}
