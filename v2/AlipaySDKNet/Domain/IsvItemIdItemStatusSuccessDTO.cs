using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvItemIdItemStatusSuccessDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IsvItemIdItemStatusSuccessDTO : AopObject
    {
        /// <summary>
        /// 外部疫苗商品ID
        /// </summary>
        [XmlElement("isv_item_id")]
        public string IsvItemId { get; set; }
    }
}
