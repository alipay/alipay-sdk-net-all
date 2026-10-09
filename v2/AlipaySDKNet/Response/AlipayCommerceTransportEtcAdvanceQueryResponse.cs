using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcAdvanceQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcAdvanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 行程垫资未还列表
        /// </summary>
        [XmlArray("trip_advance_list")]
        [XmlArrayItem("etc_trip_advance_detail")]
        public List<EtcTripAdvanceDetail> TripAdvanceList { get; set; }
    }
}
