using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserTaskDetailResponse Data Structure.
    /// </summary>
    [Serializable]
    public class UserTaskDetailResponse : AopObject
    {
        /// <summary>
        /// 信用单号
        /// </summary>
        [XmlElement("credit_no")]
        public string CreditNo { get; set; }

        /// <summary>
        /// 最近参与任务时间
        /// </summary>
        [XmlElement("last_date")]
        public string LastDate { get; set; }

        /// <summary>
        /// 商家外部单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 消费总笔数
        /// </summary>
        [XmlElement("pay_count")]
        public long PayCount { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 上报门店名称
        /// </summary>
        [XmlElement("send_shop_name")]
        public string SendShopName { get; set; }

        /// <summary>
        /// 首次参与任务时间
        /// </summary>
        [XmlElement("sign_date")]
        public string SignDate { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("uid_open_id")]
        public string UidOpenId { get; set; }

        /// <summary>
        /// 用户任务id
        /// </summary>
        [XmlElement("user_task_id")]
        public string UserTaskId { get; set; }

        /// <summary>
        /// 用户任务扣款状态
        /// </summary>
        [XmlElement("user_task_pay_status")]
        public string UserTaskPayStatus { get; set; }

        /// <summary>
        /// 用户任务状态
        /// </summary>
        [XmlElement("user_task_status")]
        public string UserTaskStatus { get; set; }
    }
}
