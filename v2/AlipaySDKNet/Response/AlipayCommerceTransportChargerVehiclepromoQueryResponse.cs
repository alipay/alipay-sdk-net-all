using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportChargerVehiclepromoQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportChargerVehiclepromoQueryResponse : AopResponse
    {
        /// <summary>
        /// 获取签名后的业务数据
        /// </summary>
        [XmlElement("orderStr")]
        public string OrderStr { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("promos")]
        [XmlArrayItem("vehicle_promo_result")]
        public List<VehiclePromoResult> Promos { get; set; }
    }
}
