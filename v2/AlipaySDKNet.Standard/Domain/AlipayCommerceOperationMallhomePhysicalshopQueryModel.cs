using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationMallhomePhysicalshopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationMallhomePhysicalshopQueryModel : AopObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 页码，不能小于1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页每页的数量，在1-100之间
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
