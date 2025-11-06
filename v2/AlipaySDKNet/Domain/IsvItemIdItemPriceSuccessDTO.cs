using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvItemIdItemPriceSuccessDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IsvItemIdItemPriceSuccessDTO : AopObject
    {
        /// <summary>
        /// 外部疫苗商品ID
        /// </summary>
        [XmlElement("isv_item_id")]
        public string IsvItemId { get; set; }
    }
}
