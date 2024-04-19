using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudFundWalletDepositorderCreateResponse.
    /// </summary>
    public class AlipayCloudFundWalletDepositorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 资金单据
        /// </summary>
        [XmlElement("fund_order_id")]
        public string FundOrderId { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
