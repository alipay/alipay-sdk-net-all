using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FailCarInfos Data Structure.
    /// </summary>
    [Serializable]
    public class FailCarInfos : AopObject
    {
        /// <summary>
        /// 设备卡号
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 备案失败原因
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

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
