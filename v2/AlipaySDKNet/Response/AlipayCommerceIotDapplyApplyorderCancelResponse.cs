using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyApplyorderCancelResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyApplyorderCancelResponse : AopResponse
    {
        /// <summary>
        /// 设备申请业务订单号与传入值相同
        /// </summary>
        [XmlElement("order_biz_id")]
        public string OrderBizId { get; set; }

        /// <summary>
        /// 返回请求成功后订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }
    }
}
