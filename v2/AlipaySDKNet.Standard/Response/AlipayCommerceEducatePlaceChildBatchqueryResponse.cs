using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducatePlaceChildBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducatePlaceChildBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 位置列表
        /// </summary>
        [XmlArray("place_list")]
        [XmlArrayItem("edu_place_info")]
        public List<EduPlaceInfo> PlaceList { get; set; }
    }
}
