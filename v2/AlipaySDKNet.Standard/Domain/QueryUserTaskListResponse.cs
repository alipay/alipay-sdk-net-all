using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryUserTaskListResponse Data Structure.
    /// </summary>
    [Serializable]
    public class QueryUserTaskListResponse : AopObject
    {
        /// <summary>
        /// 用户下信用单生成的芝麻单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户创建活动时使用的奖品名
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖品所对应的价格，单位元
        /// </summary>
        [XmlElement("prize_price")]
        public string PrizePrice { get; set; }

        /// <summary>
        /// 商户创建的任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 商户创建的活动名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务所对应的资金状态 INIT：初始化 WAIT_USER_CONFIRM：待用户确认扣款 PAYING：扣款中 PAYED：已扣款 NON_PAY：无需扣款
        /// </summary>
        [XmlElement("task_pay_status")]
        public string TaskPayStatus { get; set; }

        /// <summary>
        /// 用户的任务状态 NON_SIGN_UP：未报名 SIGN_UP：已报名 GOING：参与中 TIMEOUT：任务超期 DONE：任务结束
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 用户任务id
        /// </summary>
        [XmlElement("user_task_id")]
        public string UserTaskId { get; set; }
    }
}
