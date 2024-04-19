using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserGamecenterPaymentQuerystatusResponse.
    /// </summary>
    public class AlipayUserGamecenterPaymentQuerystatusResponse : AopResponse
    {
        /// <summary>
        /// 开发者在下单的时候传入的cp_extra字段
        /// </summary>
        [XmlElement("cp_extra")]
        public string CpExtra { get; set; }

        /// <summary>
        /// CP开发者查询到这几种状态的处理逻辑: success: 订单成功, 正常推进道具发放流程 closed: 订单已关闭, 推进开发者本地订单状态等流程refunded: 订单已退款, 推进开发者本地订单状态等流程 processing: 中间状态, 需要开发者持续轮询, 直到获得明确状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
