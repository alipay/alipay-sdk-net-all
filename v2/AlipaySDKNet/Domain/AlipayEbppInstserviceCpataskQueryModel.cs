using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInstserviceCpataskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInstserviceCpataskQueryModel : AopObject
    {
        /// <summary>
        /// 分销渠道的定义，由运营侧统一分配。
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// cpa子任务ID
        /// </summary>
        [XmlElement("sub_task_id")]
        public string SubTaskId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
