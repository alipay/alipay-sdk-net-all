using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecyclingInvoiceBizTransfer Data Structure.
    /// </summary>
    [Serializable]
    public class RecyclingInvoiceBizTransfer : AopObject
    {
        /// <summary>
        /// 支付宝侧的支付流水号，转账成功后返回
        /// </summary>
        [XmlElement("alipay_pay_no")]
        public string AlipayPayNo { get; set; }

        /// <summary>
        /// 系统生成的业务转账唯一标识
        /// </summary>
        [XmlElement("biz_transfer_id")]
        public string BizTransferId { get; set; }

        /// <summary>
        /// 企业在转账平台的开户账户标识
        /// </summary>
        [XmlElement("company_account_id")]
        public string CompanyAccountId { get; set; }

        /// <summary>
        /// 转账失败时的错误码
        /// </summary>
        [XmlElement("fail_code")]
        public string FailCode { get; set; }

        /// <summary>
        /// 转账失败时的错误描述
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 转账支付完成的时间
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 外部系统传入的转账单号，用于幂等控制
        /// </summary>
        [XmlElement("out_biz_transfer_id")]
        public string OutBizTransferId { get; set; }

        /// <summary>
        /// 业务来源标识
        /// </summary>
        [XmlElement("out_source")]
        public string OutSource { get; set; }

        /// <summary>
        /// 收款方账号，与 payee_account_type 对应
        /// </summary>
        [XmlElement("payee_account")]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// 收款账号类型枚举：PHONE-手机号，EMAIL-邮箱
        /// </summary>
        [XmlElement("payee_account_type")]
        public string PayeeAccountType { get; set; }

        /// <summary>
        /// 收款方真实姓名
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 通过 receiptId 关联回单表获取的文件下载地址
        /// </summary>
        [XmlElement("receipt_file_url")]
        public string ReceiptFileUrl { get; set; }

        /// <summary>
        /// 关联回单记录表的主键ID
        /// </summary>
        [XmlElement("receipt_id")]
        public long ReceiptId { get; set; }

        /// <summary>
        /// 关联的反向开票订单唯一标识
        /// </summary>
        [XmlElement("recycling_order_id")]
        public string RecyclingOrderId { get; set; }

        /// <summary>
        /// 转账金额，单位为元，精确到分，最多两位小数
        /// </summary>
        [XmlElement("transfer_biz_amount")]
        public string TransferBizAmount { get; set; }

        /// <summary>
        /// 转账状态枚举：INIT-已创建，SUCCESS-转账成功，FAIL-转账失败
        /// </summary>
        [XmlElement("transfer_biz_status")]
        public string TransferBizStatus { get; set; }

        /// <summary>
        /// 转账业务类型枚举：COMMISSION-平台抽佣/服务费，LOGISTICS-物流费
        /// </summary>
        [XmlElement("transfer_biz_type")]
        public string TransferBizType { get; set; }
    }
}
