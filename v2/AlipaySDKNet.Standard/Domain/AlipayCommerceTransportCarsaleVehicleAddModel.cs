using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportCarsaleVehicleAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportCarsaleVehicleAddModel : AopObject
    {
        /// <summary>
        /// 二手车数据字段
        /// </summary>
        [XmlArray("car_data")]
        [XmlArrayItem("transfer_car_data")]
        public List<TransferCarData> CarData { get; set; }
    }
}
