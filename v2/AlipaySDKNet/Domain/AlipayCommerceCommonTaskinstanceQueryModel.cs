using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonTaskinstanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonTaskinstanceQueryModel : AopObject
    {
        /// <summary>
        /// 导购的userId
        /// </summary>
        [XmlElement("hunter_id")]
        public string HunterId { get; set; }

        /// <summary>
        /// 导购的openId
        /// </summary>
        [XmlElement("hunter_open_id")]
        public string HunterOpenId { get; set; }

        /// <summary>
        /// 代运营商户id
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 任务实例id
        /// </summary>
        [XmlElement("task_instance_id")]
        public string TaskInstanceId { get; set; }

        /// <summary>
        /// 任务模板id
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }
    }
}
