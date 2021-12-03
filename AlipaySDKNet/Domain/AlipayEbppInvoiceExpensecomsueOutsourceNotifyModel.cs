using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel : AopObject
    {
        /// <summary>
        /// 企业码账号
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 消费金额（单位：分）正整数，金额必须大于0， 200 表示金额为2元
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 交易发生时间
        /// </summary>
        [XmlElement("deal_time")]
        public string DealTime { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 0 员工支付宝账号，1 员工公司员工号
        /// </summary>
        [XmlElement("employee_id_type")]
        public long EmployeeIdType { get; set; }

        /// <summary>
        /// 定制化字段传入,当前无约定规则（例如：部分调用方传入餐补餐期-中餐（L），晚餐(D)）
        /// </summary>
        [XmlElement("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// 0 是扣款，1 退款
        /// </summary>
        [XmlElement("is_off_set")]
        public long IsOffSet { get; set; }

        /// <summary>
        /// 外部唯一交易ID（幂等）
        /// </summary>
        [XmlElement("out_source_id")]
        public string OutSourceId { get; set; }

        /// <summary>
        /// 调用者身份（道安- DAO_AN，企业福利平台WELFARE_PLATFORM），接入接口分配的身份标记
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 退款流水ID，多次退款此ID不同，退款必须传入
        /// </summary>
        [XmlElement("relate_no")]
        public string RelateNo { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }
    }
}
