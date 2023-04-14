using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicAccountDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicAccountDeleteModel : AopObject
    {
        /// <summary>
        /// 协议号，商户会员在支付宝服务窗账号中的唯一标识，与bind_account_no不能同时为空
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 绑定帐号，建议在开发者的系统中保持唯一性，与agreement_id不能同时为空
        /// </summary>
        [XmlElement("bind_account_no")]
        public string BindAccountNo { get; set; }

        /// <summary>
        /// 绑定用户的支付宝userid，2088开头16位长度的字符串，与agreementId不能同时为空
        /// </summary>
        [XmlElement("from_user_id")]
        public string FromUserId { get; set; }

        /// <summary>
        /// 支付宝用户的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
