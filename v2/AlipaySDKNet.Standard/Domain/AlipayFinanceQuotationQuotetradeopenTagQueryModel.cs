using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeopenTagQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceQuotationQuotetradeopenTagQueryModel : AopObject
    {
        /// <summary>
        /// 标签查询请求，必传
        /// </summary>
        [XmlElement("obj_tag_request")]
        public ObjTagRequest ObjTagRequest { get; set; }
    }
}
