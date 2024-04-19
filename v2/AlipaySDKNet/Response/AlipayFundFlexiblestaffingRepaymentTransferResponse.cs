using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundFlexiblestaffingRepaymentTransferResponse.
    /// </summary>
    public class AlipayFundFlexiblestaffingRepaymentTransferResponse : AopResponse
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 资金单ID
        /// </summary>
        [XmlElement("fund_order_id")]
        public string FundOrderId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 还款转账产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 转账单据状态。 SUCCESS（该笔转账交易成功）：成功； FAIL：失败（具体失败原因请参见error_code以及fail_reason返回值）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 转账完成时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("trans_date")]
        public string TransDate { get; set; }
    }
}
