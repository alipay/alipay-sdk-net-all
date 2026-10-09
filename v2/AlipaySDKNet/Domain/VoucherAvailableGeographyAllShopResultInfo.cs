using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableGeographyAllShopResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableGeographyAllShopResultInfo : AopObject
    {
        /// <summary>
        /// 请求失败的不可用门店详情。
        /// </summary>
        [XmlArray("fail_exclude_shop_infos")]
        [XmlArrayItem("voucher_fail_shop_info")]
        public List<VoucherFailShopInfo> FailExcludeShopInfos { get; set; }

        /// <summary>
        /// 请求成功的不可用门店列表。
        /// </summary>
        [XmlArray("success_exclude_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> SuccessExcludeShopIds { get; set; }
    }
}
