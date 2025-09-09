using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcFundSignApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcFundSignApplyModel : AopObject
    {
        /// <summary>
        /// 系统自动生成企业唯一标识
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 出资账户类型
        /// </summary>
        [XmlElement("fund_account_type")]
        public string FundAccountType { get; set; }

        /// <summary>
        /// 是否进行企业同人校验，检验信息为社会信用代码 默认开启
        /// </summary>
        [XmlElement("identity_verify")]
        public bool IdentityVerify { get; set; }

        /// <summary>
        /// 签约终端类型
        /// </summary>
        [XmlElement("sign_terminal")]
        public string SignTerminal { get; set; }

        /// <summary>
        /// 签约人支付宝账号类型
        /// </summary>
        [XmlElement("signer_category")]
        public string SignerCategory { get; set; }
    }
}
