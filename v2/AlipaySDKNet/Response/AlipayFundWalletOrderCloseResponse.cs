using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletOrderCloseResponse.
    /// </summary>
    public class AlipayFundWalletOrderCloseResponse : AopResponse
    {
        /// <summary>
        /// 关单是否成功
        /// </summary>
        [XmlElement("close_order")]
        public bool CloseOrder { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("fund_order_id")]
        public string FundOrderId { get; set; }
    }
}
