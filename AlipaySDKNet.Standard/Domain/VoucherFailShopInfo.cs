using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherFailShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherFailShopInfo : AopObject
    {
        /// <summary>
        /// 请求失败提示信息
        /// </summary>
        [XmlElement("fail_message")]
        public string FailMessage { get; set; }

        /// <summary>
        /// 请求失败的原因。 枚举值: SHOP_INFO_NOT_PASS:门店信息不全 SHOP_NOT_EXIST:门店不存在 MERCHANT_SHOP_RELATION_NOT_EXIST:门店与商户没有关联关系 ACTIVITY_SHOP_NOT_EXIST:活动不存在该门店
        /// </summary>
        [XmlArray("fail_reasons")]
        [XmlArrayItem("string")]
        public List<string> FailReasons { get; set; }

        /// <summary>
        /// 请求失败的物理门店id
        /// </summary>
        [XmlElement("real_shop_id")]
        public string RealShopId { get; set; }

        /// <summary>
        /// 请求失败的支付门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
