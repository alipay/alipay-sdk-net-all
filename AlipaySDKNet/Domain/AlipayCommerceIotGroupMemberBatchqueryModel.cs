using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotGroupMemberBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotGroupMemberBatchqueryModel : AopObject
    {
        /// <summary>
        /// 分组id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("limit")]
        public string Limit { get; set; }

        /// <summary>
        /// 分页搜索偏移值
        /// </summary>
        [XmlElement("offset")]
        public long Offset { get; set; }
    }
}
