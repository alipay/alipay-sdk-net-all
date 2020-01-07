using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniPlanOperateCreateResponse.
    /// </summary>
    public class AlipayOpenMiniPlanOperateCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建支付后推荐方案返回的方案id，后续用户可根据该方案ID对方案进行终止和调整优先级
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
