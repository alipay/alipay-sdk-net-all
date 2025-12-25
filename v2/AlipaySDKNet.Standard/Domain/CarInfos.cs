using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarInfos Data Structure.
    /// </summary>
    [Serializable]
    public class CarInfos : AopObject
    {
        /// <summary>
        /// 设备卡号
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }
    }
}
