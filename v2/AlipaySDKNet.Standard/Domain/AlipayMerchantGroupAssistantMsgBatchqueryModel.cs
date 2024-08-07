using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupAssistantMsgBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupAssistantMsgBatchqueryModel : AopObject
    {
        /// <summary>
        /// 小助手类型列表，目前支持 activity_recommend (自定义活动)、benefit_recommend（优惠券推荐）
        /// </summary>
        [XmlArray("biz_type_list")]
        [XmlArrayItem("string")]
        public List<string> BizTypeList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页查询条数，最大50条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 小助手消息状态   INIT (初始化),  AUDITING (审核中),  DENY (审核驳回),  PENDING (待生效),  VALID (生效),  INVALID (失效),  DELETED (删除);
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
