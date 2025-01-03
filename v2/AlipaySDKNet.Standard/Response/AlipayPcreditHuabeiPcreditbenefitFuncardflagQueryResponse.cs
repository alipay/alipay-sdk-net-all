using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitFuncardflagQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditbenefitFuncardflagQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前是否有饿了么额度券
        /// </summary>
        [XmlElement("edu_quan_flag")]
        public bool EduQuanFlag { get; set; }

        /// <summary>
        /// 是否花呗签约用户
        /// </summary>
        [XmlElement("hb_sign")]
        public bool HbSign { get; set; }

        /// <summary>
        /// 是否信用购用户
        /// </summary>
        [XmlElement("hua_plus")]
        public bool HuaPlus { get; set; }

        /// <summary>
        /// 脱敏手机号
        /// </summary>
        [XmlElement("mobile_info")]
        public string MobileInfo { get; set; }

        /// <summary>
        /// 是否青春版用户
        /// </summary>
        [XmlElement("youth_flag")]
        public bool YouthFlag { get; set; }
    }
}
