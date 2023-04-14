using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderVehicleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderVehicleInfo : AopObject
    {
        /// <summary>
        /// 交通工具牌照号，如车牌号等
        /// </summary>
        [XmlElement("license_plate_no")]
        public string LicensePlateNo { get; set; }

        /// <summary>
        /// 车辆信息备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 班次
        /// </summary>
        [XmlElement("shift_no")]
        public string ShiftNo { get; set; }
    }
}
