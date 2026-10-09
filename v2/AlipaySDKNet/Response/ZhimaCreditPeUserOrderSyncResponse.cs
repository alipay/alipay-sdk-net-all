using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeUserOrderSyncResponse.
    /// </summary>
    public class ZhimaCreditPeUserOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 芝麻信用服务业务订单号
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 信用服务订单状态.  INIT: 下单状态;   WAIT_FULFILL:  订单待守约；  CLOSED：订单取消；  COMPLETE：订单已守约
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部请求幂等号，即接口入参的out_request_no，接口处理完之后回传
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 业务处理是否成功标记，成功返回true，其他情况下返回false
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
