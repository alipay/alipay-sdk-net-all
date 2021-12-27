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
        /// 企业ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 消费金额 特殊说明：单位为分的正整数
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 交易发生时间
        /// </summary>
        [XmlElement("deal_time")]
        public string DealTime { get; set; }

        /// <summary>
        /// 员工ID 特殊说明：根据员工账号类型来决定为员工UID还是员工工号
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 员工账号类型 枚举值： 0（员工支付宝账号） 1（ 员工工号）
        /// </summary>
        [XmlElement("employee_id_type")]
        public long EmployeeIdType { get; set; }

        /// <summary>
        /// 拓展参数 如需使用，请联系技术支持
        /// </summary>
        [XmlElement("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// 交易类型 枚举值： 0（扣款） 1（退款）
        /// </summary>
        [XmlElement("is_off_set")]
        public long IsOffSet { get; set; }

        /// <summary>
        /// 外部交易支付单号
        /// </summary>
        [XmlElement("out_source_id")]
        public string OutSourceId { get; set; }

        /// <summary>
        /// 外部平台编码（联系技术支持分配）
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 外部交易退款单号 特殊说明：交易类型为退款的时候传入，多次退款传入不同的退款单号
        /// </summary>
        [XmlElement("relate_no")]
        public string RelateNo { get; set; }

        /// <summary>
        /// 费控规则ID 特殊说明：该交易绑定的支付宝费控规则ID
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }
    }
}
