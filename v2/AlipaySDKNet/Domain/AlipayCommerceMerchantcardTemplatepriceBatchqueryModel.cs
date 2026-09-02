using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardTemplatepriceBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardTemplatepriceBatchqueryModel : AopObject
    {
        /// <summary>
        /// 需要查询动态价格的商品模板ID。
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 区域价查询条件；省、市、区编码最多传一个。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 区域价查询条件；省、市、区编码最多传一个。
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 页码，不传默认1。
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量，不传默认500，最大500。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 动态价格模式：2为普通日历价，3为区域价，4为门店价。
        /// </summary>
        [XmlElement("price_mode")]
        public string PriceMode { get; set; }

        /// <summary>
        /// 区域价查询条件；省、市、区编码最多传一个。
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 门店价查询条件，仅price_mode=4时可传。
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
