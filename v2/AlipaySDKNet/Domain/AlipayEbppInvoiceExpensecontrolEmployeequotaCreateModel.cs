using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel : AopObject
    {
        /// <summary>
        /// 共同账号ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 余额失效时间（默认有效期100年）
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 余额生效时间(默认当前时间)
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 外部操作幂等ID（接入方接口调用幂等控制ID）
        /// </summary>
        [XmlElement("outer_source_id")]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 切换open_id前请使用：余额所属者ID owner_type为员工时为员工支付宝ID
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 切换open_id后请使用：余额所属者ID owner_type为员工时为员工open_id
        /// </summary>
        [XmlElement("owner_open_id")]
        public string OwnerOpenId { get; set; }

        /// <summary>
        /// 余额所属者类型 EMPLOYEE: 员工
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 外部平台编码（通常为接入方大写英文缩写）
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 余额同步模式，默认 DEFAULT_STANDARD
        /// </summary>
        [XmlElement("quota_model")]
        public string QuotaModel { get; set; }

        /// <summary>
        /// 余额，以（分）为单位 特殊说明：余额不超过100000元
        /// </summary>
        [XmlElement("quota_value")]
        public string QuotaValue { get; set; }
    }
}
