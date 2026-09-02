using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardTemplatepriceDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardTemplatepriceDeleteModel : AopObject
    {
        /// <summary>
        /// 需要删除动态价格的商品模板ID。
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("city_code_list")]
        [XmlArrayItem("string")]
        public List<string> CityCodeList { get; set; }

        /// <summary>
        /// 删除普通日历价时传true，与区域价、门店价删除条件三选一。
        /// </summary>
        [XmlElement("delete_calendar_price")]
        public bool DeleteCalendarPrice { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("district_code_list")]
        [XmlArrayItem("string")]
        public List<string> DistrictCodeList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("province_code_list")]
        [XmlArrayItem("string")]
        public List<string> ProvinceCodeList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_id_list")]
        [XmlArrayItem("string")]
        public List<string> ShopIdList { get; set; }
    }
}
