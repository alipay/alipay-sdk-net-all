using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceIndustryEnergyCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceIndustryEnergyCheckModel : AopObject
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 绿色能量查询场景，如：社保=social_security，具体值请找相关同学确认
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }
    }
}
