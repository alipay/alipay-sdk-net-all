using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAccountCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAccountCheckModel : AopObject
    {
        /// <summary>
        /// 支付宝会员的登陆外标，仅支持邮箱或手机号
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 待识别的主体证件号（营业执照、统一社会信用代码）
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 待识别的用户名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
