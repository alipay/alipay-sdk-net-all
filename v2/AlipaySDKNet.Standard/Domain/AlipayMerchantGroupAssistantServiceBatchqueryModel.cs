using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupAssistantServiceBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupAssistantServiceBatchqueryModel : AopObject
    {
        /// <summary>
        /// 快捷服务名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页查询条数，最大50条
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 小助手消息状态 INIT (初始化), AUDITING (审核中), DENY (审核驳回), VALID (生效), INVALID (失效);
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
