using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEbikeChargestationdetailQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEbikeChargestationdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 两轮充电桩详情
        /// </summary>
        [XmlElement("ebike_charge_station_detail")]
        public EbikeChargeStation EbikeChargeStationDetail { get; set; }
    }
}
