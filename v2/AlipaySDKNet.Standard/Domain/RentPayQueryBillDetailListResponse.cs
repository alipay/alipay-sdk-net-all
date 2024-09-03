using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPayQueryBillDetailListResponse Data Structure.
    /// </summary>
    [Serializable]
    public class RentPayQueryBillDetailListResponse : AopObject
    {
        /// <summary>
        /// 公积金付金额，单位：元
        /// </summary>
        [XmlElement("acc_amount")]
        public string AccAmount { get; set; }

        /// <summary>
        /// 公积金付费状态
        /// </summary>
        [XmlElement("acc_pay_status")]
        public string AccPayStatus { get; set; }

        /// <summary>
        /// 账户编号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 付款批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 提取日期，日期格式都是yyyy-mm-dd
        /// </summary>
        [XmlElement("draw_date")]
        public string DrawDate { get; set; }

        /// <summary>
        /// 审批号
        /// </summary>
        [XmlElement("org_biz_no")]
        public string OrgBizNo { get; set; }

        /// <summary>
        /// 租赁机构订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("pay_cert_name")]
        public string PayCertName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("pay_cert_num")]
        public string PayCertNum { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("pay_cert_type")]
        public string PayCertType { get; set; }

        /// <summary>
        /// 付款日期，日期格式都是yyyy-mm-dd
        /// </summary>
        [XmlElement("payment_date")]
        public string PaymentDate { get; set; }

        /// <summary>
        /// 租房直付，非公积金支付金额，单位：元
        /// </summary>
        [XmlElement("self_amount")]
        public string SelfAmount { get; set; }

        /// <summary>
        /// 银行结算流水号
        /// </summary>
        [XmlElement("settle_serial_no")]
        public string SettleSerialNo { get; set; }

        /// <summary>
        /// 房租总金额，单位:元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
