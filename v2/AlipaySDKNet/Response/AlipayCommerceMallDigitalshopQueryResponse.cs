using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMallDigitalshopQueryResponse.
    /// </summary>
    public class AlipayCommerceMallDigitalshopQueryResponse : AopResponse
    {
        /// <summary>
        /// 商圈下数字化门店信息列表
        /// </summary>
        [XmlArray("digital_shop_list")]
        [XmlArrayItem("digital_shop_info")]
        public List<DigitalShopInfo> DigitalShopList { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 商圈名称，eg：上海长宁来福士广场
        /// </summary>
        [XmlElement("mall_name")]
        public string MallName { get; set; }
    }
}
