using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherAvailableScopeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherAvailableScopeInfo : AopObject
    {
        /// <summary>
        /// 券可用商品
        /// </summary>
        [XmlArray("app_item_voucher_available_info_list")]
        [XmlArrayItem("voucher_available_app_item_info")]
        public List<VoucherAvailableAppItemInfo> AppItemVoucherAvailableInfoList { get; set; }
    }
}
