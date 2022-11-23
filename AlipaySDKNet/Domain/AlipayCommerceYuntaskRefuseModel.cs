using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskRefuseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskRefuseModel : AopObject
    {
        /// <summary>
        /// 出资方id
        /// </summary>
        [XmlElement("funder_id")]
        public string FunderId { get; set; }

        /// <summary>
        /// 出资方类型，品牌方:BRAND
        /// </summary>
        [XmlElement("funder_type")]
        public string FunderType { get; set; }

        /// <summary>
        /// 操作者uid
        /// </summary>
        [XmlElement("operate_open_id")]
        public string OperateOpenId { get; set; }

        /// <summary>
        /// 操作者uid
        /// </summary>
        [XmlElement("operate_user_id")]
        public string OperateUserId { get; set; }

        /// <summary>
        /// 零售商pid，任务所有者
        /// </summary>
        [XmlElement("owner_pid")]
        public string OwnerPid { get; set; }

        /// <summary>
        /// 任务模版id
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }
    }
}
