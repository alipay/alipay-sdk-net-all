using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectPromotaskTakeResponse.
    /// </summary>
    public class AlipayMerchantIndirectPromotaskTakeResponse : AopResponse
    {
        /// <summary>
        /// 支付宝侧生产的商家任务编号
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务状态，枚举值： - START，任务开始 - CANCEL，任务取消 - FINISH，任务完成
        /// </summary>
        [XmlElement("task_state")]
        public string TaskState { get; set; }
    }
}
