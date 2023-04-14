using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarVehicleInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarVehicleInfoQueryModel : AopObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        [XmlElement("vi_id")]
        public string ViId { get; set; }
    }
}
