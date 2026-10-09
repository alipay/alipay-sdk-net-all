using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromconfigureSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantPayforprivilegePromconfigureSetModel : AopObject
    {
        /// <summary>
        /// 支持的可核销门店列表
        /// </summary>
        [XmlArray("enabled_shop_list")]
        [XmlArrayItem("string")]
        public List<string> EnabledShopList { get; set; }

        /// <summary>
        /// 需要剔除的单品id列表，不可同时与（support_item_ids）生效
        /// </summary>
        [XmlArray("exclude_item_ids")]
        [XmlArrayItem("string")]
        public List<string> ExcludeItemIds { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支持的核销单品id列表，不可同时与剔除的列表（exclude_item_ids）生效
        /// </summary>
        [XmlArray("support_item_ids")]
        [XmlArrayItem("string")]
        public List<string> SupportItemIds { get; set; }
    }
}
