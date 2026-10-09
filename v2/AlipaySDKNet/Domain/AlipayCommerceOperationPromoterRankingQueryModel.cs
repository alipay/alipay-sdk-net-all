using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationPromoterRankingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationPromoterRankingQueryModel : AopObject
    {
        /// <summary>
        /// 需要绑定的门店对映的pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 任务code，唯一标识
        /// </summary>
        [XmlElement("task_code")]
        public string TaskCode { get; set; }

        /// <summary>
        /// total
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 店员id，点击提交的收银员id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
