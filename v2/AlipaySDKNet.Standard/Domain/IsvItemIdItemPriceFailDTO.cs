using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvItemIdItemPriceFailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IsvItemIdItemPriceFailDTO : AopObject
    {
        /// <summary>
        /// 记录本条商品操作失败详情
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 外部疫苗商品ID
        /// </summary>
        [XmlElement("isv_item_id")]
        public string IsvItemId { get; set; }
    }
}
