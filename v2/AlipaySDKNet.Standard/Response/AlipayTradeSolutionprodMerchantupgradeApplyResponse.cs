using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSolutionprodMerchantupgradeApplyResponse.
    /// </summary>
    public class AlipayTradeSolutionprodMerchantupgradeApplyResponse : AopResponse
    {
        /// <summary>
        /// 用于直接跳转至用户升级确认页面
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 升级申请单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// INIT：获取返回的jump_url跳转至支付宝端进行用户确认、 PROCESSING：已存升级申请，正在处理中、SUCCESS：已存升级申请开通成功，RETRY:升级请求失败，可通过查询接口alipay.trade.solutionprod.merchantupgrade.query获取具体失败原因，解决后续使用原单重试
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
