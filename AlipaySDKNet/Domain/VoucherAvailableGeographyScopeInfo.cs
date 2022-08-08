using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableGeographyScopeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableGeographyScopeInfo : AopObject
    {
        /// <summary>
        /// 券可用城市
        /// </summary>
        [XmlElement("available_geography_city_info")]
        public VoucherAvailableGeographyCityInfo AvailableGeographyCityInfo { get; set; }

        /// <summary>
        /// 券可用地理位置类型。 枚举值： SHOP:可用门店 CITY_CODE:可用城市
        /// </summary>
        [XmlElement("available_geography_scope_type")]
        public string AvailableGeographyScopeType { get; set; }

        /// <summary>
        /// 券可用门店
        /// </summary>
        [XmlElement("available_geography_shop_info")]
        public VoucherAvailableGeographyShopInfo AvailableGeographyShopInfo { get; set; }
    }
}
