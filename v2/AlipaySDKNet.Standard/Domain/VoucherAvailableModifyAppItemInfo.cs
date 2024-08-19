using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableModifyAppItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableModifyAppItemInfo : AopObject
    {
        /// <summary>
        /// 外部商品信息
        /// </summary>
        [XmlElement("app_item_out_item_info")]
        public AppItemModifyOutItemInfo AppItemOutItemInfo { get; set; }

        /// <summary>
        /// 需要查询优惠信息的商品支付宝平台侧ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
