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
        /// 企业因公代付的资金账户
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 系统自动生成企业唯一标识
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 出资账户类型 当前字段已废弃(请使用fund_source与account_type)
        /// </summary>
        [XmlElement("fund_account_type")]
        public string FundAccountType { get; set; }

        /// <summary>
        /// 不同资金来源时需要填写补充信息
        /// </summary>
        [XmlElement("fund_constraint")]
        public FundConstraints FundConstraint { get; set; }

        /// <summary>
        /// 企业因公代付的资金来源
        /// </summary>
        [XmlElement("fund_source")]
        public string FundSource { get; set; }

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

        /// <summary>
        /// 限定出资的银行卡号 当前字段已废弃(请使用fund_constraint进行设置)
        /// </summary>
        [XmlElement("specified_bank_card_no")]
        public string SpecifiedBankCardNo { get; set; }

        /// <summary>
        /// 是否使用企业创建人支付宝账号出资 <br/>1、为true时表示选择企业创建人的支付宝账号出资 <br/>2、为false时表示选择企业其他支付宝账号，需登录账号进行授权
        /// </summary>
        [XmlElement("use_creator_alipay_account")]
        public bool UseCreatorAlipayAccount { get; set; }
    }
}
