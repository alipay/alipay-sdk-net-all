using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarDataserviceMaintainvehicleShareResponse.
    /// </summary>
    public class AlipayEcoMycarDataserviceMaintainvehicleShareResponse : AopResponse
    {
        /// <summary>
        /// 车辆详细信息
        /// </summary>
        [XmlElement("info")]
        public MaintainVehicleInfo Info { get; set; }
    }
}
