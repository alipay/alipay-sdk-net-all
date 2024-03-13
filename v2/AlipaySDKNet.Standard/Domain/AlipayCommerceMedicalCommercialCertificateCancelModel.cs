using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialCertificateCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCommercialCertificateCancelModel : AopObject
    {
        /// <summary>
        /// 用户openid，唯一映射用户userid，用于唯一标识用户
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户兑换开通凭证的唯一业务流水号
        /// </summary>
        [XmlElement("out_no")]
        public string OutNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户兑换凭证时登录或指定的手机号码
        /// </summary>
        [XmlElement("user_mobile")]
        public string UserMobile { get; set; }
    }
}
