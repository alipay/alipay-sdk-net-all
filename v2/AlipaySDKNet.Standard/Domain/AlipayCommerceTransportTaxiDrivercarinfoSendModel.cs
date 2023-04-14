using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDrivercarinfoSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiDrivercarinfoSendModel : AopObject
    {
        /// <summary>
        /// 出租车司机车辆信息列表
        /// </summary>
        [XmlArray("driver_car_info_list")]
        [XmlArrayItem("driver_car_info")]
        public List<DriverCarInfo> DriverCarInfoList { get; set; }

        /// <summary>
        /// 请求时间
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }
    }
}
