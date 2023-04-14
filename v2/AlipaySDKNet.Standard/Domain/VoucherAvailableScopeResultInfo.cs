using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableScopeResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableScopeResultInfo : AopObject
    {
        /// <summary>
        /// 可用地理位置。
        /// </summary>
        [XmlElement("voucher_available_geography_scope_result_info")]
        public VoucherAvailableGeographyScopeResultInfo VoucherAvailableGeographyScopeResultInfo { get; set; }
    }
}
