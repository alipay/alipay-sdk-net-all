using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTravelRecordQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTravelRecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户乘车记录数据，按日期分类
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("travel_record")]
        public List<TravelRecord> Data { get; set; }
    }
}
