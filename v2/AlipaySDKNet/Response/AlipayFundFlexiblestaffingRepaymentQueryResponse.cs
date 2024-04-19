using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundFlexiblestaffingRepaymentQueryResponse.
    /// </summary>
    public class AlipayFundFlexiblestaffingRepaymentQueryResponse : AopResponse
    {
        /// <summary>
        /// 资金单Id
        /// </summary>
        [XmlElement("fund_order_id")]
        public string FundOrderId { get; set; }

        /// <summary>
        /// 外部唯一订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 完成转账时间
        /// </summary>
        [XmlElement("trans_date")]
        public string TransDate { get; set; }
    }
}
