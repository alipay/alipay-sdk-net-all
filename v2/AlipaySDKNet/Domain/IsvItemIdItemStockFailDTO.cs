using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvItemIdItemStockFailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IsvItemIdItemStockFailDTO : AopObject
    {
        /// <summary>
        /// 记录本条疫苗操作失败原因
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 外部服务商疫苗商品ID
        /// </summary>
        [XmlElement("isv_item_id")]
        public string IsvItemId { get; set; }
    }
}
