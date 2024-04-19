using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SalePlanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SalePlanInfo : AopObject
    {
        /// <summary>
        /// 个性化价格描述
        /// </summary>
        [XmlElement("custom_price_desc")]
        public string CustomPriceDesc { get; set; }

        /// <summary>
        /// 主(销售方案id)商品id
        /// </summary>
        [XmlElement("main_ps_id")]
        public string MainPsId { get; set; }

        /// <summary>
        /// 价格描述
        /// </summary>
        [XmlElement("price_desc")]
        public string PriceDesc { get; set; }

        /// <summary>
        /// 特殊价格:STANDARD_PRICE/CUSTOM_PRICE
        /// </summary>
        [XmlElement("price_type")]
        public string PriceType { get; set; }

        /// <summary>
        /// 销售方案或者商品列表
        /// </summary>
        [XmlElement("ps_id")]
        public string PsId { get; set; }
    }
}
