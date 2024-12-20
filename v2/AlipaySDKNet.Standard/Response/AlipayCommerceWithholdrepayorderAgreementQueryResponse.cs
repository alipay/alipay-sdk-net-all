using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWithholdrepayorderAgreementQueryResponse.
    /// </summary>
    public class AlipayCommerceWithholdrepayorderAgreementQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户签约成功后的协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 返回脱敏的支付宝账号
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 业务代扣计划，包含某协议号所关联的全部代扣计划
        /// </summary>
        [XmlElement("biz_withhold_plans")]
        public IndustryWithholdPlanDTO BizWithholdPlans { get; set; }

        /// <summary>
        /// 授信模式，目前只在花芝代扣（即花芝go）协议时才会返回
        /// </summary>
        [XmlElement("credit_auth_mode")]
        public string CreditAuthMode { get; set; }

        /// <summary>
        /// 设备Id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 还款计划列表
        /// </summary>
        [XmlElement("execution_plans")]
        public ExecutionPlan ExecutionPlans { get; set; }

        /// <summary>
        /// 代扣协议中标示用户的唯一签约号(确保在商户系统中唯一)。当入参中传了此参数时返回。
        /// </summary>
        [XmlElement("external_agreement_no")]
        public string ExternalAgreementNo { get; set; }

        /// <summary>
        /// 外部登录Id。当入参中传了此参数时返回。
        /// </summary>
        [XmlElement("external_logon_id")]
        public string ExternalLogonId { get; set; }

        /// <summary>
        /// 协议失效时间，格式为 yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("invalid_time")]
        public string InvalidTime { get; set; }

        /// <summary>
        /// 周期扣协议，上次扣款成功时间
        /// </summary>
        [XmlElement("last_deduct_time")]
        public string LastDeductTime { get; set; }

        /// <summary>
        /// 周期扣协议，预计下次扣款时间
        /// </summary>
        [XmlElement("next_deduct_time")]
        public string NextDeductTime { get; set; }

        /// <summary>
        /// 签约主体类型。
        /// </summary>
        [XmlElement("pricipal_type")]
        public string PricipalType { get; set; }

        /// <summary>
        /// 签约主体标识。 当principal_type为CARD 时，该字段为支付宝用户号
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 签约主体标识。 当principal_type为CARD 时，该字段为支付宝用户号
        /// </summary>
        [XmlElement("principal_open_id")]
        public string PrincipalOpenId { get; set; }

        /// <summary>
        /// 签约协议的场景。
        /// </summary>
        [XmlElement("sign_scene")]
        public string SignScene { get; set; }

        /// <summary>
        /// 协议签约时间，格式为 yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 单笔代扣额度，单位为元
        /// </summary>
        [XmlElement("single_quota")]
        public string SingleQuota { get; set; }

        /// <summary>
        /// 协议履约节点，依照还款业务单类型变化，不同类型会有不同的履约节点
        /// </summary>
        [XmlElement("stage")]
        public string Stage { get; set; }

        /// <summary>
        /// 协议当前状态 1. TEMP：暂存，协议未生效过； 2. NORMAL：正常； 3. STOP：暂停
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 签约第三方主体类型。对于三方协议，表示当前用户和哪一类的第三方主体进行签约。 默认为PARTNER。
        /// </summary>
        [XmlElement("third_party_type")]
        public string ThirdPartyType { get; set; }

        /// <summary>
        /// 协议生效时间，格式为 yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("valid_time")]
        public string ValidTime { get; set; }

        /// <summary>
        /// 用户的芝麻信用 openId，供商 户查询用户芝麻信用使用。
        /// </summary>
        [XmlElement("zm_open_id")]
        public string ZmOpenId { get; set; }
    }
}
