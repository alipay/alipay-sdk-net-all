using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportCarsaleVehicleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportCarsaleVehicleModifyModel : AopObject
    {
        /// <summary>
        /// 车辆更新数据对象，主要更新 status 和 price 字段
        /// </summary>
        [XmlArray("car_data")]
        [XmlArrayItem("transfer_car_update_data")]
        public List<TransferCarUpdateData> CarData { get; set; }
    }
}
