using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentGoods Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentGoods : AopObject
    {
        /// <summary>
        /// 商品品牌
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 商品类目编码
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 商品单价。单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("unit_amount")]
        public string UnitAmount { get; set; }

        /// <summary>
        /// 商品单价币种
        /// </summary>
        [XmlElement("unit_currency")]
        public string UnitCurrency { get; set; }
    }
}
