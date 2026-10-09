using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanSideloansignCreditConsultResponse.
    /// </summary>
    public class AlipayPcreditLoanSideloansignCreditConsultResponse : AopResponse
    {
        /// <summary>
        /// true - 有签约方案 false - 无签约方案
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 用户支付宝登陆ID(脱敏后的)
        /// </summary>
        [XmlElement("alipay_desensitize_login_id")]
        public string AlipayDesensitizeLoginId { get; set; }

        /// <summary>
        /// 冷静期类型，LONG-长，SHORT-短，NONE-无
        /// </summary>
        [XmlElement("cool_off_type")]
        public string CoolOffType { get; set; }

        /// <summary>
        /// 默认放款卡，只有签支合一才有，可能会空
        /// </summary>
        [XmlElement("default_bank_card")]
        public GrantBankCard DefaultBankCard { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 失败原因编码
        /// </summary>
        [XmlElement("fail_reason_code")]
        public string FailReasonCode { get; set; }

        /// <summary>
        /// 失败原因描述
        /// </summary>
        [XmlElement("fail_reason_message")]
        public string FailReasonMessage { get; set; }

        /// <summary>
        /// 授信机构列表
        /// </summary>
        [XmlElement("fund_supplier")]
        public InstitutionVO FundSupplier { get; set; }

        /// <summary>
        /// 同人账号其他支付宝账号
        /// </summary>
        [XmlElement("other_alipay_densey_login_id")]
        public string OtherAlipayDenseyLoginId { get; set; }

        /// <summary>
        /// 表示请求处理状态。 SUCCESS - 成功 NEED_RETRY -需要重试 FAIL - 不可重试
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// returnCode为FAIL或者NEED_RETRY状态下，返回具体错误码
        /// </summary>
        [XmlElement("return_sub_code")]
        public string ReturnSubCode { get; set; }

        /// <summary>
        /// 可以详细描述失败原因，方便双方定位问题
        /// </summary>
        [XmlElement("return_sub_message")]
        public string ReturnSubMessage { get; set; }

        /// <summary>
        /// 限权解绑链接
        /// </summary>
        [XmlElement("un_limit_url")]
        public string UnLimitUrl { get; set; }

        /// <summary>
        /// 用户姓名(脱敏后的)
        /// </summary>
        [XmlElement("user_desensitize_name")]
        public string UserDesensitizeName { get; set; }
    }
}
