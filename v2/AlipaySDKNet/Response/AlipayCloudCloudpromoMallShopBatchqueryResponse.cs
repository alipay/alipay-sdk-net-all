using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMallShopBatchqueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMallShopBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 单页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 店铺列表
        /// </summary>
        [XmlArray("shop_list")]
        [XmlArrayItem("shop_v_o")]
        public List<ShopVO> ShopList { get; set; }

        /// <summary>
        /// 总量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
