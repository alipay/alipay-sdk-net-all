using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsInfoDTO : AopObject
    {
        /// <summary>
        /// 商品金额
        /// </summary>
        [XmlElement("goods_amount")]
        public string GoodsAmount { get; set; }

        /// <summary>
        /// 商品购买数量
        /// </summary>
        [XmlElement("goods_count")]
        public string GoodsCount { get; set; }

        /// <summary>
        /// 商品标准69码
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }
    }
}
