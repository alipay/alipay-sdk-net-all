using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasCrowdListBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasCrowdListBatchqueryModel : AopObject
    {
        /// <summary>
        /// 操作人ID+唯一+人群列表查询
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 页数+不唯一+人群列表查询
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小+不唯一+人群列表查询
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 人群名称+不唯一+人群列表查询
        /// </summary>
        [XmlElement("query_key")]
        public string QueryKey { get; set; }

        /// <summary>
        /// 人群状态+不唯一+人群列表查询
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
