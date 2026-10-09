using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceShopdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceShopdetailQueryModel : AopObject
    {
        /// <summary>
        /// 商户ID【查询非调用方门店详情必传】
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户ID【查询非调用方门店详情必传】
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 蚂蚁门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店主键ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
