using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationPointHistoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationPointHistoryQueryModel : AopObject
    {
        /// <summary>
        /// 分页数
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

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
        /// 店员id，点击提交的收银员id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
