using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportCarsaleVehicleAddResponse.
    /// </summary>
    public class AlipayCommerceTransportCarsaleVehicleAddResponse : AopResponse
    {
        /// <summary>
        /// 车辆处理结果
        /// </summary>
        [XmlArray("car_result")]
        [XmlArrayItem("transfer_car_result_resp")]
        public List<TransferCarResultResp> CarResult { get; set; }
    }
}
