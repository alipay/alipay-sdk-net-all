using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskWhitetestTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskWhitetestTriggerModel : AopObject
    {
        /// <summary>
        /// 商户pid， 代运营模式需要，超导后台操作任务对应的商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 操作者id
        /// </summary>
        [XmlElement("operate_open_id")]
        public string OperateOpenId { get; set; }

        /// <summary>
        /// 操作者id
        /// </summary>
        [XmlElement("operate_user_id")]
        public string OperateUserId { get; set; }

        /// <summary>
        /// 超导任务模版id，在超导SaaS后台针对任务点击操作时，将对应的任务id传过来
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }
    }
}
