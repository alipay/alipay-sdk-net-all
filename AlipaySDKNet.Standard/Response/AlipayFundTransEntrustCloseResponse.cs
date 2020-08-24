using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransEntrustCloseResponse.
    /// </summary>
    public class AlipayFundTransEntrustCloseResponse : AopResponse
    {
        /// <summary>
        /// 该笔委托支付在支付宝系统内部的单据ID
        /// </summary>
        [XmlElement("entrust_order_id")]
        public string EntrustOrderId { get; set; }

        /// <summary>
        /// 商户端的唯一订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// INIT，表示委托支付单据已经受理
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
