using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsMaterialsBatchqueryResponse.
    /// </summary>
    public class AlipayOpenSpNordermaterialsMaterialsBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 数据列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("shop_materials_info")]
        public List<ShopMaterialsInfo> DataList { get; set; }

        /// <summary>
        /// 生产单的数据总量，单位条
        /// </summary>
        [XmlElement("data_total")]
        public long DataTotal { get; set; }

        /// <summary>
        /// 是否还有剩余数据，用于标记是否查询完毕数据
        /// </summary>
        [XmlElement("has_next_page")]
        public bool HasNextPage { get; set; }
    }
}
