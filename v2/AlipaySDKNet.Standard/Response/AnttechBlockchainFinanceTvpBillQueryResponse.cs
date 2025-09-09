using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpBillQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinanceTvpBillQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单支付总金额，单位元
        /// </summary>
        [XmlElement("actual_total_amount")]
        public string ActualTotalAmount { get; set; }

        /// <summary>
        /// 账单调整金额，单位元
        /// </summary>
        [XmlElement("adjusted_amount")]
        public string AdjustedAmount { get; set; }

        /// <summary>
        /// 账单明细列表，可信账单场景下只有一条明细
        /// </summary>
        [XmlArray("bill_detail_list")]
        [XmlArrayItem("trust_fund_order")]
        public List<TrustFundOrder> BillDetailList { get; set; }

        /// <summary>
        /// 账单名称
        /// </summary>
        [XmlElement("bill_name")]
        public string BillName { get; set; }

        /// <summary>
        /// 账单id,数科唯一
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单产出时间
        /// </summary>
        [XmlElement("billing_date")]
        public string BillingDate { get; set; }

        /// <summary>
        /// 状态说明
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 账单核算截止时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 账单过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 账单初始总金额, 单位元
        /// </summary>
        [XmlElement("original_total_amount")]
        public string OriginalTotalAmount { get; set; }

        /// <summary>
        /// 外部账单ID
        /// </summary>
        [XmlElement("out_bill_no")]
        public string OutBillNo { get; set; }

        /// <summary>
        /// 交易备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 账单核算起始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 账单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 账单类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
