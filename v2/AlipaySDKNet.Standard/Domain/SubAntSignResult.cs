using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubAntSignResult Data Structure.
    /// </summary>
    [Serializable]
    public class SubAntSignResult : AopObject
    {
        /// <summary>
        /// 我方签署方id
        /// </summary>
        [XmlElement("our_user_id")]
        public string OurUserId { get; set; }

        /// <summary>
        /// 是否关联业务 true:关联  false：不关联
        /// </summary>
        [XmlElement("related_business")]
        public bool RelatedBusiness { get; set; }

        /// <summary>
        /// 子任务id
        /// </summary>
        [XmlElement("sign_task_id")]
        public string SignTaskId { get; set; }

        /// <summary>
        /// 子业务流水号
        /// </summary>
        [XmlElement("sub_biz_no")]
        public string SubBizNo { get; set; }
    }
}
