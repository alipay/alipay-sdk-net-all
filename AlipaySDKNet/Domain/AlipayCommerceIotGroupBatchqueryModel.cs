using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotGroupBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotGroupBatchqueryModel : AopObject
    {
        /// <summary>
        /// 业务类型-代表不同的业务场景 distribution表示服务分发
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("limit")]
        public long Limit { get; set; }

        /// <summary>
        /// 分页搜索偏移值
        /// </summary>
        [XmlElement("offset")]
        public long Offset { get; set; }
    }
}
