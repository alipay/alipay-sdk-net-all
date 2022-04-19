using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskOperationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskOperationQueryModel : AopObject
    {
        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 分页数，默认值1
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 分页大小，默认值10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 任务模版id
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }
    }
}
