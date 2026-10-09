using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtCmallGoodsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtCmallGoodsSyncModel : AopObject
    {
        /// <summary>
        /// access_goods_dto，用于商品同步
        /// </summary>
        [XmlElement("access_goods_dto")]
        public AccessGoodsDto AccessGoodsDto { get; set; }

        /// <summary>
        /// access_product_dto，用于商品同步
        /// </summary>
        [XmlElement("access_product_dto")]
        public AccessProductDto AccessProductDto { get; set; }
    }
}
