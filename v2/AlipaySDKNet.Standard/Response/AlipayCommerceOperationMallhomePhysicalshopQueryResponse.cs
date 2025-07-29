using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationMallhomePhysicalshopQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationMallhomePhysicalshopQueryResponse : AopResponse
    {
        /// <summary>
        /// 起始页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 物理门店列表
        /// </summary>
        [XmlElement("physical_shop_list")]
        public PhysicalShopInfo PhysicalShopList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
