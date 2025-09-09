using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducatePlaceInfoBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducatePlaceInfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 位置信息列表
        /// </summary>
        [XmlArray("place_info_list")]
        [XmlArrayItem("edu_place_info")]
        public List<EduPlaceInfo> PlaceInfoList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
