using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiscountVoucher Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountVoucher : AopObject
    {
        /// <summary>
        /// 封顶金额。
        /// </summary>
        [XmlElement("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 折扣率。
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 门槛金额。说明：该字段可不填，认为无门槛;
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 商品名称。说明：该字段可不填，填入则origin_amount必填。
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 原价。说明：该字段可不填，填入则商品名称goods_name必填;
        /// </summary>
        [XmlElement("origin_amount")]
        public string OriginAmount { get; set; }
    }
}
