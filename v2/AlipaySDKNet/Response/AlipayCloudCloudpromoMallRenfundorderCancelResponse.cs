using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMallRenfundorderCancelResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMallRenfundorderCancelResponse : AopResponse
    {
        /// <summary>
        /// 纠纷id
        /// </summary>
        [XmlElement("dispute_id")]
        public string DisputeId { get; set; }

        /// <summary>
        /// 1-退货待处理 2-待买家退货 3-待商家收货 4-退款关闭 5-退款成功 6-已拒绝退款 17-取消退款中
        /// </summary>
        [XmlElement("dispute_status")]
        public long DisputeStatus { get; set; }

        /// <summary>
        /// 子分销订单号
        /// </summary>
        [XmlElement("order_line_id")]
        public string OrderLineId { get; set; }
    }
}
