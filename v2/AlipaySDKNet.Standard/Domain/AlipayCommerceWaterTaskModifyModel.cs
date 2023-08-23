using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceWaterTaskModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceWaterTaskModifyModel : AopObject
    {
        /// <summary>
        /// 奖品信息
        /// </summary>
        [XmlElement("prize_content")]
        public PrizeContent PrizeContent { get; set; }

        /// <summary>
        /// 任务有效期结束
        /// </summary>
        [XmlElement("task_end")]
        public string TaskEnd { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
