using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcAssetAuthorizeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcAssetAuthorizeApplyModel : AopObject
    {
        /// <summary>
        /// 共同账户ID 当前字段已废弃(account_id及agreement_no兼容字段不再需要)
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号 当前字段已废弃(account_id及agreement_no兼容字段不再需要)
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 资产类型，每个类型都有对应的一组签约操作，关联关系如下： a. 企业余额：因公付签约（ENT_PAY_SIGN）； b. 上海华瑞银行授信：华瑞银行授信申请（ENT_SHRB_CREDIT）-> 因公付签约（ENT_PAY_SIGN）；
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 签约类型
        /// </summary>
        [XmlElement("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 企业法人支付宝登录账号，资产申请人在法人授信申请流程填写，系统会对其进行有效性校验 当前字段已废弃(资产类型"法人信用卡"不支持，其流程需要的法人账号信息也不再需要)
        /// </summary>
        [XmlElement("ebe_alipay_logon_id")]
        public string EbeAlipayLogonId { get; set; }

        /// <summary>
        /// 企业支付宝登录账号
        /// </summary>
        [XmlElement("ent_alipay_logon_id")]
        public string EntAlipayLogonId { get; set; }

        /// <summary>
        /// 企业Id，企业入驻企业码时自动分配的企业身份唯一标识
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 外部业务编号，调用方生成的用于唯一标识授信申请的单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 签约终端类型，默认MOBILE
        /// </summary>
        [XmlElement("sign_terminal")]
        public string SignTerminal { get; set; }
    }
}
