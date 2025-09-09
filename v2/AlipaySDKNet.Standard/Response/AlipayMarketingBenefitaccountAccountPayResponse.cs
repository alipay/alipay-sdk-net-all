using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingBenefitaccountAccountPayResponse.
    /// </summary>
    public class AlipayMarketingBenefitaccountAccountPayResponse : AopResponse
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 拉起pc端收银台链接
        /// </summary>
        [XmlElement("pc_payment_url")]
        public string PcPaymentUrl { get; set; }

        /// <summary>
        /// 充值订单号
        /// </summary>
        [XmlElement("recharge_no")]
        public string RechargeNo { get; set; }
    }
}
