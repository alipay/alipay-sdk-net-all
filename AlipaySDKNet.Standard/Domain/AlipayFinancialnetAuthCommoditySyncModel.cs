using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthCommoditySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthCommoditySyncModel : AopObject
    {
        /// <summary>
        /// 同步商品信息
        /// </summary>
        [XmlArray("commodity_infos")]
        [XmlArrayItem("commodity_info_list")]
        public List<CommodityInfoList> CommodityInfos { get; set; }

        /// <summary>
        /// 幂等字段
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 平台标识
        /// </summary>
        [XmlElement("platform_id")]
        public string PlatformId { get; set; }
    }
}
