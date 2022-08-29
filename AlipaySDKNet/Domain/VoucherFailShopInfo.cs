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
        /// 请求失败提示信息。
        /// </summary>
        [XmlElement("fail_message")]
        public string FailMessage { get; set; }

        /// <summary>
        /// 请求失败的原因。
        /// </summary>
        [XmlArray("fail_reasons")]
        [XmlArrayItem("string")]
        public List<string> FailReasons { get; set; }

        /// <summary>
        /// 请求失败的物理门店 id。
        /// </summary>
        [XmlElement("real_shop_id")]
        public string RealShopId { get; set; }

        /// <summary>
        /// 请求失败的支付门店 ID。
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
