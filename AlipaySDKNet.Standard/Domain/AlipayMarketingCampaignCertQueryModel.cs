using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCertQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignCertQueryModel : AopObject
    {
        /// <summary>
        /// 营销平台凭证批次号，可能是数字和字母的组合
        /// </summary>
        [XmlElement("cert_template_id")]
        public string CertTemplateId { get; set; }

        /// <summary>
        /// 用户登录账号名：邮箱或手机号。已知支付宝账号的活动触发调用中，user_id与login_id至少有一个非空，都非空时，以user_id为准。
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID：支付宝用户唯一标识。该参数用于已知支付宝账号的活动触发。user_id、login_id两个参数至少有一个非空。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
