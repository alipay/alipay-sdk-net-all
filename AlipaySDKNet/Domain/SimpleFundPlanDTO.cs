using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SimpleFundPlanDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SimpleFundPlanDTO : AopObject
    {
        /// <summary>
        /// 合花群ID（与当前请求参数中传入值保持一致）
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// （创建人）支付宝侧用户唯一标识<br> - 补充说明：该字段与alipay.fund.jointaccount.fundplan.create请求参数中传入值保持一致
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 当前合花群中的自动攒计划唯一标识（支付宝侧生成）
        /// </summary>
        [XmlElement("fund_plan_id")]
        public string FundPlanId { get; set; }

        /// <summary>
        /// 计划状态<br> - VALIDATE：正常生效中<br> - PAUSE 暂停中<br> - CLOSED 已删除
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
