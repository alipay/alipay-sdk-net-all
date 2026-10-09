using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarQuoteadvQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarQuoteadvQueryModel : AopObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 车型id
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("sku_sname")]
        public string SkuSname { get; set; }

        /// <summary>
        /// 起始城市名称
        /// </summary>
        [XmlElement("start_city_name")]
        public string StartCityName { get; set; }
    }
}
