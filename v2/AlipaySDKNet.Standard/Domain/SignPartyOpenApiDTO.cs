using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignPartyOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SignPartyOpenApiDTO : AopObject
    {
        /// <summary>
        /// 主体注册地址
        /// </summary>
        [XmlElement("address")]
        public AddressOpenApiDTO Address { get; set; }

        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 公司编码类型
        /// </summary>
        [XmlElement("corp_type")]
        public string CorpType { get; set; }

        /// <summary>
        /// 联系邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 身份标识id
        /// </summary>
        [XmlElement("identity_id")]
        public string IdentityId { get; set; }

        /// <summary>
        /// 主体名称（当partyType=CORPRATION时，不能为空）
        /// </summary>
        [XmlElement("party_name")]
        public string PartyName { get; set; }

        /// <summary>
        /// 主体类型
        /// </summary>
        [XmlElement("party_type")]
        public string PartyType { get; set; }

        /// <summary>
        /// 个人编码类型,（当partyType=PERSONAL时，不能为空）
        /// </summary>
        [XmlElement("personal_type")]
        public string PersonalType { get; set; }
    }
}
