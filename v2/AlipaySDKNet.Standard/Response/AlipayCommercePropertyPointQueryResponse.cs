using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyPointQueryResponse.
    /// </summary>
    public class AlipayCommercePropertyPointQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("location_point_info_v_o")]
        public List<LocationPointInfoVO> List { get; set; }

        /// <summary>
        /// 数据总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
