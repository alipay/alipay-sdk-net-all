using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampusPointQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCampusPointQueryResponse : AopResponse
    {
        /// <summary>
        /// 校区点位信息
        /// </summary>
        [XmlArray("campus_point_detail_list")]
        [XmlArrayItem("campus_point_detail")]
        public List<CampusPointDetail> CampusPointDetailList { get; set; }
    }
}
