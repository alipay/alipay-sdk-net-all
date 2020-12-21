using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchServiceorderBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchServiceorderBatchqueryModel : AopObject
    {
        /// <summary>
        /// 服务搜索申请单分页入参
        /// </summary>
        [XmlElement("biz_data")]
        public SearchApplyPageQueryRequest BizData { get; set; }

        /// <summary>
        /// 表示查询内容的类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 操作的类型，如query
        /// </summary>
        [XmlElement("opt_type")]
        public string OptType { get; set; }
    }
}
