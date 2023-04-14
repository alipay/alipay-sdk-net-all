using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotContentBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotContentBatchqueryModel : AopObject
    {
        /// <summary>
        /// 分页页号，从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询条件，根据不同场景可能有所不同
        /// </summary>
        [XmlElement("query_condition")]
        public string QueryCondition { get; set; }

        /// <summary>
        /// 请求ID，标识唯一一次请求，串联调用方的内部链路
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 场景码，用于指定当前查询数据所属的业务场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
