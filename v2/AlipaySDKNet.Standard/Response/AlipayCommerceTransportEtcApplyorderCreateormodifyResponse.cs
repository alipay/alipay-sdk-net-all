using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcApplyorderCreateormodifyResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcApplyorderCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝ETC申请单号
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// SUCCESS:成功;FAIL:失败原因
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 其他业务异常信息描述 ORDER_NOT_EXIST:订单不存在 ORDER_STATUS_ILLEGAL:订单状态非法
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }
    }
}
