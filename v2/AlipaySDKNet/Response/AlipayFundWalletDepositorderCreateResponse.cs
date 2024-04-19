using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletDepositorderCreateResponse.
    /// </summary>
    public class AlipayFundWalletDepositorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 内部单据
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 资金单据
        /// </summary>
        [XmlElement("fund_order_id")]
        public string FundOrderId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
