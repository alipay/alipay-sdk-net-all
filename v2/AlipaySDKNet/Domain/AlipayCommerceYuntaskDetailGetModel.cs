using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskDetailGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskDetailGetModel : AopObject
    {
        /// <summary>
        /// 出资方pid，出资方模式下必传merchant_pid
        /// </summary>
        [XmlElement("funder_id")]
        public string FunderId { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 任务模版id
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }
    }
}
