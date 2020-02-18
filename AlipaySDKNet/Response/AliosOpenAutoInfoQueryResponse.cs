using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AliosOpenAutoInfoQueryResponse.
    /// </summary>
    public class AliosOpenAutoInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 发动机号
        /// </summary>
        [XmlElement("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }

        /// <summary>
        /// 车辆识别号码
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
