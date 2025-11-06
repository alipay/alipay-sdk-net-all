using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSolutionprodUnifiedopenApplyResponse.
    /// </summary>
    public class AlipayTradeSolutionprodUnifiedopenApplyResponse : AopResponse
    {
        /// <summary>
        /// 用于直接跳转至用户聚合开通页面
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 聚合开通申请单号
        /// </summary>
        [XmlElement("uniopen_order_id")]
        public string UniopenOrderId { get; set; }

        /// <summary>
        /// 当状态为PROCESSING/SUCCESS/FAIL时可通过查询接口alipay.merchant.ctoc.unifiedopen.query获取最新开通子项开通信息。  INIT：获取返回的jump_url跳转至支付宝端进行用户确认、 PROCESSING：已存聚合申请，正在开通中、SUCCESS：已存聚合申请开通成功，FAIL:开通失败（包括部分失败）
        /// </summary>
        [XmlElement("uniopen_status")]
        public string UniopenStatus { get; set; }
    }
}
