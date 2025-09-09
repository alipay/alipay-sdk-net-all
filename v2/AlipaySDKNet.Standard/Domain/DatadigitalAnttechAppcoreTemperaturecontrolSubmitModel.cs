using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechAppcoreTemperaturecontrolSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechAppcoreTemperaturecontrolSubmitModel : AopObject
    {
        /// <summary>
        /// 企业统一社会信用代码，和热力公司定义保持一致
        /// </summary>
        [XmlElement("company_uscc")]
        public string CompanyUscc { get; set; }

        /// <summary>
        /// 采暖模式
        /// </summary>
        [XmlElement("heating_mode")]
        public string HeatingMode { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 住户id，热力公司自定义的id，数据来源热力公司
        /// </summary>
        [XmlElement("resident_id")]
        public string ResidentId { get; set; }

        /// <summary>
        /// 室内温度，单位为摄氏度
        /// </summary>
        [XmlElement("room_temperature")]
        public string RoomTemperature { get; set; }

        /// <summary>
        /// 设定的温度，单位为摄氏度
        /// </summary>
        [XmlElement("set_temperature")]
        public string SetTemperature { get; set; }

        /// <summary>
        /// 设定的时间
        /// </summary>
        [XmlElement("set_time")]
        public string SetTime { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
