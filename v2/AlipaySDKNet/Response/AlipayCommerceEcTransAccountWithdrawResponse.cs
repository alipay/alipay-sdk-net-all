using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcTransAccountWithdrawResponse.
    /// </summary>
    public class AlipayCommerceEcTransAccountWithdrawResponse : AopResponse
    {
        /// <summary>
        /// 该笔提现在支付宝系统内部的单据ID
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户端的唯一订单号，对于同一笔充值请求，商户需保证该订单号唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 提现状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
