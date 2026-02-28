using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceServiceDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceServiceDeleteModel : AopObject
    {
        /// <summary>
        /// 三方场地id【需保证唯一性】
        /// </summary>
        [XmlElement("out_service_id")]
        public string OutServiceId { get; set; }

        /// <summary>
        /// 服务项目id【和out_service_id二选一】
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
