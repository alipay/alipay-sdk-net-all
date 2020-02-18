using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcApplySyncResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcApplySyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝内部生成的orderid
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 同步结果：0 失败, 1成功
        /// </summary>
        [XmlElement("sync_result")]
        public string SyncResult { get; set; }
    }
}
