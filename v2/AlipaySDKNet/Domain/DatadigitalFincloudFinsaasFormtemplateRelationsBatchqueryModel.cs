using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasFormtemplateRelationsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasFormtemplateRelationsBatchqueryModel : AopObject
    {
        /// <summary>
        /// marketing_type + 关联关系查询 + 前端。
        /// </summary>
        [XmlElement("marketing_type")]
        public string MarketingType { get; set; }

        /// <summary>
        /// page_num + 关联关系查询 + 前端
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// page_size + 关联关系查询 + 前端
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
