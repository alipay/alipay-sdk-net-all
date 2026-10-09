using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpBillSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceTvpBillSubmitModel : AopObject
    {
        /// <summary>
        /// 账单实际支付金额，单位元 original_total_amount + adjust_amount = actual_total_amount
        /// </summary>
        [XmlElement("actual_total_amount")]
        public string ActualTotalAmount { get; set; }

        /// <summary>
        /// 账单调整金额，单位元。减免金额输入负数，增加金额输入正数 original_total_amount + adjust_amount = actual_total_amount
        /// </summary>
        [XmlElement("adjusted_amount")]
        public string AdjustedAmount { get; set; }

        /// <summary>
        /// 账单业务信息。
        /// </summary>
        [XmlElement("bill_biz_info")]
        public string BillBizInfo { get; set; }

        /// <summary>
        /// 账单名称
        /// </summary>
        [XmlElement("bill_name")]
        public string BillName { get; set; }

        /// <summary>
        /// 账单产出时间
        /// </summary>
        [XmlElement("billing_date")]
        public string BillingDate { get; set; }

        /// <summary>
        /// 账单核算截止时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 订单过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 账单初始总金额，单位元
        /// </summary>
        [XmlElement("original_total_amount")]
        public string OriginalTotalAmount { get; set; }

        /// <summary>
        /// 外部账单id，商户唯一
        /// </summary>
        [XmlElement("out_bill_no")]
        public string OutBillNo { get; set; }

        /// <summary>
        /// 收款方账号未管控的场景，需传入收款方账号。 payee_entity 和 payee_account 不能都为空。
        /// </summary>
        [XmlElement("payee_account")]
        public TrustAccountInfo PayeeAccount { get; set; }

        /// <summary>
        /// 针对收款方账号管控的场景，只需要传入收款方主体名称即可，无需传入收款方账号。 payee_entity 和 payee_account 不能都为空
        /// </summary>
        [XmlElement("payee_entity")]
        public TrustEntityInfo PayeeEntity { get; set; }

        /// <summary>
        /// 付款方主体
        /// </summary>
        [XmlElement("payer_entity")]
        public TrustEntityInfo PayerEntity { get; set; }

        /// <summary>
        /// 可信价值中心产品码，接入时由对应业务同学提供
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 备注|附言
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 账单核算起始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 账单类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
