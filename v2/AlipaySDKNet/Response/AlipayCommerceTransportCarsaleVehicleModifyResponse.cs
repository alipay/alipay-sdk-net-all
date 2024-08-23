using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportCarsaleVehicleModifyResponse.
    /// </summary>
    public class AlipayCommerceTransportCarsaleVehicleModifyResponse : AopResponse
    {
        /// <summary>
        /// 车辆处理结果返回
        /// </summary>
        [XmlArray("car_result")]
        [XmlArrayItem("transfer_car_result_resp")]
        public List<TransferCarResultResp> CarResult { get; set; }
    }
}
