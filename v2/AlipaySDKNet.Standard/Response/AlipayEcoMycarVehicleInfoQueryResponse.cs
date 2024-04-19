using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarVehicleInfoQueryResponse.
    /// </summary>
    public class AlipayEcoMycarVehicleInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 车辆信息列表
        /// </summary>
        [XmlArray("vehicle_list")]
        [XmlArrayItem("vehicle_info_dto")]
        public List<VehicleInfoDto> VehicleList { get; set; }
    }
}
