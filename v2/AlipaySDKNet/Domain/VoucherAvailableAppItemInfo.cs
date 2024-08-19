using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableAppItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableAppItemInfo : AopObject
    {
        /// <summary>
        /// 外部商品信息
        /// </summary>
        [XmlElement("app_item_out_item_info")]
        public AppItemOutItemInfo AppItemOutItemInfo { get; set; }

        /// <summary>
        /// 需要查询优惠信息的商品支付宝平台侧ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
