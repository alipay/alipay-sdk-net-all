using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniIcpAreaQueryResponse.
    /// </summary>
    public class AlipayOpenMiniIcpAreaQueryResponse : AopResponse
    {
        /// <summary>
        /// 省市区列表信息
        /// </summary>
        [XmlArray("area_items")]
        [XmlArrayItem("icp_province_area_item_list")]
        public List<IcpProvinceAreaItemList> AreaItems { get; set; }
    }
}
