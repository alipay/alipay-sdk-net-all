using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateRoleInfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateRoleInfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 分页页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
