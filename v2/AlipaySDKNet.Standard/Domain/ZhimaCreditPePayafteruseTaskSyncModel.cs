using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPePayafteruseTaskSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPePayafteruseTaskSyncModel : AopObject
    {
        /// <summary>
        /// 实际业务动作的发生时间，比如任务完成的业务时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 任务流水的类型
        /// </summary>
        [XmlElement("goal_type")]
        public string GoalType { get; set; }

        /// <summary>
        /// 代表一次任务推进的进度值，格式为固定数字，在MONEY类型下单位为分，在TIMES类型下单位为次
        /// </summary>
        [XmlElement("goal_value")]
        public string GoalValue { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商家侧的订单号，用于幂等控制
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部请求幂等号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 完结；取消；权益核销
        /// </summary>
        [XmlElement("update_type")]
        public string UpdateType { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
