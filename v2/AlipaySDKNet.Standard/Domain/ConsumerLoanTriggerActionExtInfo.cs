using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanTriggerActionExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanTriggerActionExtInfo : AopObject
    {
        /// <summary>
        /// 触发事件中的动作类型，REPAY代表用户发生了还款
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 当前动作所对应的实体，范围由小到大为：还款计划->账单->借据->全部
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 幂等号，代表当前一次动作事件
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 还款金额，单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("paid_amount")]
        public long PaidAmount { get; set; }

        /// <summary>
        /// 用户还款时间
        /// </summary>
        [XmlElement("paid_time")]
        public string PaidTime { get; set; }
    }
}
