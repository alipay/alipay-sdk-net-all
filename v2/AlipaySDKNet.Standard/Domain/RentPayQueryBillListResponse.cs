using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPayQueryBillListResponse Data Structure.
    /// </summary>
    [Serializable]
    public class RentPayQueryBillListResponse : AopObject
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 收款银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行收款账号
        /// </summary>
        [XmlElement("bank_no")]
        public string BankNo { get; set; }

        /// <summary>
        /// 付款批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 批次汇总金额（单位元）
        /// </summary>
        [XmlElement("batch_total_amount")]
        public string BatchTotalAmount { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 付款日期，日期格式都是yyyy-mm-dd
        /// </summary>
        [XmlElement("payment_date")]
        public string PaymentDate { get; set; }

        /// <summary>
        /// 银行结算流水号
        /// </summary>
        [XmlElement("settle_serial_no")]
        public string SettleSerialNo { get; set; }
    }
}
