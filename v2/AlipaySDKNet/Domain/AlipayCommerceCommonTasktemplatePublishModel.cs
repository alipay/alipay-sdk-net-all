using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonTasktemplatePublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonTasktemplatePublishModel : AopObject
    {
        /// <summary>
        /// 代运营的商户id
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 操作者的openId
        /// </summary>
        [XmlElement("operate_open_id")]
        public string OperateOpenId { get; set; }

        /// <summary>
        /// 操作者的id
        /// </summary>
        [XmlElement("operate_user_id")]
        public string OperateUserId { get; set; }

        /// <summary>
        /// 任务模板id
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }
    }
}
