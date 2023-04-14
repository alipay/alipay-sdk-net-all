using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarViolationVehicleQueryResponse.
    /// </summary>
    public class AlipayEcoMycarViolationVehicleQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户车辆发动机号
        /// </summary>
        [XmlElement("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 用户车辆ID,支付宝系统唯一
        /// </summary>
        [XmlElement("vi_id")]
        public string ViId { get; set; }

        /// <summary>
        /// 用户车辆车牌号
        /// </summary>
        [XmlElement("vi_number")]
        public string ViNumber { get; set; }

        /// <summary>
        /// 用户车辆识别码
        /// </summary>
        [XmlElement("vin_no")]
        public string VinNo { get; set; }
    }
}
