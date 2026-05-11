using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDtbankcustDailydiscountuserQueryResponse.
    /// </summary>
    public class AlipayUserDtbankcustDailydiscountuserQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前活动状态
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 用户报名该天天减活动状态
        /// </summary>
        [XmlElement("user_register")]
        public string UserRegister { get; set; }

        /// <summary>
        /// 用户报名后优惠信息
        /// </summary>
        [XmlElement("user_register_discount_info")]
        public UserRegisterDiscountInfo UserRegisterDiscountInfo { get; set; }

        /// <summary>
        /// 活动参与进度信息
        /// </summary>
        [XmlArray("user_task_progress")]
        [XmlArrayItem("user_task_progress")]
        public List<UserTaskProgress> UserTaskProgress { get; set; }
    }
}
