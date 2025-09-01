using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportParkingAssistantQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportParkingAssistantQueryModel : AopObject
    {
        /// <summary>
        /// 车牌颜色，如果不填，则默认7位位蓝色，8位为绿色； 枚举值： 蓝:BLUE 绿:GREEN 黄:YELLOW 白:WHITE 黑:BLACK 黄绿色:LIMEGREEN 橄榄色:OLIVINE 未知:UNKNOWN
        /// </summary>
        [XmlElement("license_plate_color")]
        public string LicensePlateColor { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("license_plate_no")]
        public string LicensePlateNo { get; set; }
    }
}
