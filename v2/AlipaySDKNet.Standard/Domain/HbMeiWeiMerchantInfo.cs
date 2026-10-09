using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HbMeiWeiMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HbMeiWeiMerchantInfo : AopObject
    {
        /// <summary>
        /// 商户门店logo地址
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        [XmlArray("shop_list")]
        [XmlArrayItem("hb_mei_weishop_info")]
        public List<HbMeiWeishopInfo> ShopList { get; set; }
    }
}
