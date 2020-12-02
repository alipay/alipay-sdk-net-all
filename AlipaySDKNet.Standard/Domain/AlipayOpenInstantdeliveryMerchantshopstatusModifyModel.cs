using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantshopstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenInstantdeliveryMerchantshopstatusModifyModel : AopObject
    {
        /// <summary>
        /// 要更新的商家门店列表
        /// </summary>
        [XmlArray("merchant_shop_infos")]
        [XmlArrayItem("merchant_shop_info")]
        public List<MerchantShopInfo> MerchantShopInfos { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
