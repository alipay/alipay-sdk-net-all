using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskWhiteuserDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskWhiteuserDeleteModel : AopObject
    {
        /// <summary>
        /// 操作人open id
        /// </summary>
        [XmlElement("operate_open_id")]
        public string OperateOpenId { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [XmlElement("operate_user_id")]
        public string OperateUserId { get; set; }

        /// <summary>
        /// 超导任务模版id，在超导SaaS后台针对任务点击操作时，将对应的任务id传过来
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }

        /// <summary>
        /// 白名单手机号
        /// </summary>
        [XmlElement("white_phone")]
        public string WhitePhone { get; set; }
    }
}
