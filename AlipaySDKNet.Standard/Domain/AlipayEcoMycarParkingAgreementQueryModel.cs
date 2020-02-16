using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingAgreementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingAgreementQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID；只有传入该参数才能准确的匹配车和用户的关系，否则有可能无法正确获取到用户的代扣状态。
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 车牌，用户车辆进场时ISV设备识别到的车辆牌照
        /// </summary>
        [XmlElement("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 接口版本号，不填则默认为v2.0，建议使用最新版v2.1
        /// </summary>
        [XmlElement("ver")]
        public string Ver { get; set; }
    }
}
