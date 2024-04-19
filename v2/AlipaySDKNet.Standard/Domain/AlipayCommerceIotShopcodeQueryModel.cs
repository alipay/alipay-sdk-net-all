using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotShopcodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotShopcodeQueryModel : AopObject
    {
        /// <summary>
        /// 设备绑定的商户pid，直连场景填写商户收单pid，间连场景填写smid绑定的pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 设备绑定的门店shopid
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
