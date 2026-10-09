using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransGroupfundsPayorderCreateResponse.
    /// </summary>
    public class AlipayFundTransGroupfundsPayorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务类型,客户端透传给收银台。默认值：biz_account_transfer
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 付款实际关联的订单号，小程序唤起收银台后传入进行支付
        /// </summary>
        [XmlElement("transfer_no")]
        public string TransferNo { get; set; }
    }
}
