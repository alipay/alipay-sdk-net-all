using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniPoiQueryResponse.
    /// </summary>
    public class AlipayOpenMiniPoiQueryResponse : AopResponse
    {
        /// <summary>
        /// 可添加地址的最大数量
        /// </summary>
        [XmlElement("max_count")]
        public long MaxCount { get; set; }

        /// <summary>
        /// POI信息列表
        /// </summary>
        [XmlArray("nearby_address_info_list")]
        [XmlArrayItem("nearby_address_info")]
        public List<NearbyAddressInfo> NearbyAddressInfoList { get; set; }

        /// <summary>
        /// 当前已添加地址数量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
