using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateMpcpromoDataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateMpcpromoDataQueryModel : AopObject
    {
        /// <summary>
        /// 物品的唯一id
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 查询起始页数
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 查询条数 最高200条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
