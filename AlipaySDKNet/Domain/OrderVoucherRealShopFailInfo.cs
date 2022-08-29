using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderVoucherRealShopFailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderVoucherRealShopFailInfo : AopObject
    {
        /// <summary>
        /// 请求失败提示信息。
        /// </summary>
        [XmlElement("fail_message")]
        public string FailMessage { get; set; }

        /// <summary>
        /// 请求失败原因。
        /// </summary>
        [XmlArray("fail_reasons")]
        [XmlArrayItem("string")]
        public List<string> FailReasons { get; set; }

        /// <summary>
        /// 请求失败的代运营商业关系门店 ID。
        /// </summary>
        [XmlElement("real_shop_id")]
        public string RealShopId { get; set; }
    }
}
