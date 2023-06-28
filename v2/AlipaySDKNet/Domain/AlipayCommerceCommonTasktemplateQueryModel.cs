using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonTasktemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonTasktemplateQueryModel : AopObject
    {
        /// <summary>
        /// 代运营商户id
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 任务模板id
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }
    }
}
