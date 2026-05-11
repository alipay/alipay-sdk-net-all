using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinVehicleVerificationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinVehicleVerificationInfo : AopObject
    {
        /// <summary>
        /// 人车一致标识
        /// </summary>
        [XmlElement("vehicle_self_flag")]
        public string VehicleSelfFlag { get; set; }
    }
}
