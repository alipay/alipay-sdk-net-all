using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehownerbaseBenefitTakeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportVehownerbaseBenefitTakeModel : AopObject
    {
        /// <summary>
        /// 城市编码，用于判断城市过滤规则。例如330310等，非固定值，由业务运营圈定权益参加范围。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 权益组件集
        /// </summary>
        [XmlElement("components")]
        public BenefitActionComponents Components { get; set; }

        /// <summary>
        /// 设备信息
        /// </summary>
        [XmlElement("device_info")]
        public BenefitDeviceInfo DeviceInfo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 权益方案标识，指定业务场景，从运营业务方获取
        /// </summary>
        [XmlElement("operation_param_identify")]
        public string OperationParamIdentify { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
