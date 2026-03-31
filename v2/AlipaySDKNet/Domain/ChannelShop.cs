using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelShop Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelShop : AopObject
    {
        /// <summary>
        /// 蚂蚁门店进件所属阶段
        /// </summary>
        [XmlElement("progress")]
        public string Progress { get; set; }

        /// <summary>
        /// 蚂蚁门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
