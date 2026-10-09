using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcShoppoolActivityshopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcShoppoolActivityshopQueryModel : AopObject
    {
        /// <summary>
        /// 企业id，企业领域的唯一标识
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 分页中的页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页展示的门店个数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
