using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOrderauthTokenApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportOrderauthTokenApplyModel : AopObject
    {
        /// <summary>
        /// 16位支付宝小程序应用APPID，默认是当前调用方
        /// </summary>
        [XmlElement("auth_appid")]
        public string AuthAppid { get; set; }

        /// <summary>
        /// 授权行业编码，由支付宝业务人员分配
        /// </summary>
        [XmlElement("auth_industry")]
        public string AuthIndustry { get; set; }

        /// <summary>
        /// 额外参数
        /// </summary>
        [XmlElement("ext_info")]
        public AuthTokenApplyExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        [XmlElement("id_card_number")]
        public string IdCardNumber { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
