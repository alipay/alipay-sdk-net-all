using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodMerchantQueryResponse.
    /// </summary>
    public class AlipayMerchantSolcreditserviceprodMerchantQueryResponse : AopResponse
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
        /// 商家自定义
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
        /// 失败原因
        /// </summary>
        [XmlElement("review_fail_reason")]
        public string ReviewFailReason { get; set; }

        /// <summary>
        /// 初始化: INIT; 审核中: UNDER_REVIEW; 已通过: PASSED; 未通过: FAILED
        /// </summary>
        [XmlElement("review_status")]
        public string ReviewStatus { get; set; }

        /// <summary>
        /// 最新审核版本号
        /// </summary>
        [XmlElement("review_version_no")]
        public string ReviewVersionNo { get; set; }

        /// <summary>
        /// 信用服务风控配置，为必传字段。此字段为复杂模型，其中类目code为必传属性。
        /// </summary>
        [XmlElement("risk_config")]
        public RiskConfigDTO RiskConfig { get; set; }

        /// <summary>
        /// 对应使用场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 直付通进件
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 初始化: INIT; 正常: NORMAL
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 为空则表示暂无审核通过版本
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }
    }
}
