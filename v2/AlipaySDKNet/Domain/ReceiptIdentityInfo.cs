using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReceiptIdentityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiptIdentityInfo : AopObject
    {
        /// <summary>
        /// 收单身份名称
        /// </summary>
        [XmlElement("identity_name")]
        public string IdentityName { get; set; }

        /// <summary>
        /// 商户PID/SMID（合作伙伴ID）
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 门店ID，不传则代表该商户下所有门店
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
