using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoImageOptimizeApplyResponse.
    /// </summary>
    public class AlipayCloudCloudpromoImageOptimizeApplyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝内部订单id，唯一
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号，原样返回商户请求号
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
