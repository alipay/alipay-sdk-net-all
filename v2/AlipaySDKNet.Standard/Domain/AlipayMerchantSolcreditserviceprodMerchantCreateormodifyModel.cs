using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodMerchantCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantSolcreditserviceprodMerchantCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 用户支付金额结算账户 填入支付宝账户（手机号或邮箱）
        /// </summary>
        [XmlElement("alipay_settlement_account")]
        public string AlipaySettlementAccount { get; set; }

        /// <summary>
        /// 不传则默认小程序首页
        /// </summary>
        [XmlElement("app_jump_link")]
        public string AppJumpLink { get; set; }

        /// <summary>
        /// 商户邮箱
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 座机或手机
        /// </summary>
        [XmlElement("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// 服务商抽成比例（百分比）
        /// </summary>
        [XmlElement("isv_separate_ledger_rate")]
        public string IsvSeparateLedgerRate { get; set; }

        /// <summary>
        /// 需要使用通用图片上传接口返回的链接
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 商户使用的小程序ID
        /// </summary>
        [XmlElement("merchant_app_id")]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// 商户名称，商家自定义
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 其余分账账户信息
        /// </summary>
        [XmlArray("other_settle_account_list")]
        [XmlArrayItem("other_settle_account_d_t_o")]
        public List<OtherSettleAccountDTO> OtherSettleAccountList { get; set; }

        /// <summary>
        /// 信用服务守护配置，为必传字段。此字段为复杂模型，其中商户服务电话为必传属性。
        /// </summary>
        [XmlElement("promise_config")]
        public PromiseConfigDTO PromiseConfig { get; set; }

        /// <summary>
        /// 信用服务风控配置
        /// </summary>
        [XmlElement("risk_config")]
        public RiskConfigDTO RiskConfig { get; set; }

        /// <summary>
        /// 对应使用场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 二级商户 ID，直付通进件
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
