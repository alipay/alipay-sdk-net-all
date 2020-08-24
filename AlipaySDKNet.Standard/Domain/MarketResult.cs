using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MarketResult Data Structure.
    /// </summary>
    [Serializable]
    public class MarketResult : AopObject
    {
        /// <summary>
        /// 营销信息列表
        /// </summary>
        [XmlArray("price_detail_list")]
        [XmlArrayItem("price_detail_d_t_o")]
        public List<PriceDetailDTO> PriceDetailList { get; set; }

        /// <summary>
        /// 用于区分营销场景，例如打车星巴克
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
