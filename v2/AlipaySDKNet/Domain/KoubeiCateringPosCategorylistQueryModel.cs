using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringPosCategorylistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCategorylistQueryModel : AopObject
    {
        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
