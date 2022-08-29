using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableGeographyScopeResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableGeographyScopeResultInfo : AopObject
    {
        /// <summary>
        /// 可用门店结果。
        /// </summary>
        [XmlElement("available_geography_shop_result_info")]
        public VoucherAvailableGeographyShopResultInfo AvailableGeographyShopResultInfo { get; set; }
    }
}
