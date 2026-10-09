using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniIsvQueryResponse.
    /// </summary>
    public class AlipayOpenMiniIsvQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序appId，商家确认后非空，若商家未确认或超时返回空
        /// </summary>
        [XmlElement("min_app_id")]
        public string MinAppId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单号，开发者帐号+外部订单号维度来控制请求务幂等
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// PROCESS处理中，TIMEOUT超时，AGREED同意， REJECTED拒绝
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
