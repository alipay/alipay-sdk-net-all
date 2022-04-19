using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationTimescardOrderCreateResponse.
    /// </summary>
    public class AlipayCommerceOperationTimescardOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 是否需要调用jsapi确认向卡包发卡
        /// </summary>
        [XmlElement("is_need_invoke_jsapi")]
        public bool IsNeedInvokeJsapi { get; set; }

        /// <summary>
        /// 卡包发卡token
        /// </summary>
        [XmlElement("kabao_token")]
        public string KabaoToken { get; set; }

        /// <summary>
        /// 次卡订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 拉起收银台的订单参数
        /// </summary>
        [XmlElement("order_str")]
        public string OrderStr { get; set; }
    }
}
