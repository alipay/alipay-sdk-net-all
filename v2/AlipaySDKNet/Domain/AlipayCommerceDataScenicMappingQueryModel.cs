using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceDataScenicMappingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDataScenicMappingQueryModel : AopObject
    {
        /// <summary>
        /// 景区审核信息查询请求。 集合长度不能超过200
        /// </summary>
        [XmlArray("scenic_audit_query_req")]
        [XmlArrayItem("scenic_audit_query_req")]
        public List<ScenicAuditQueryReq> ScenicAuditQueryReq { get; set; }
    }
}
