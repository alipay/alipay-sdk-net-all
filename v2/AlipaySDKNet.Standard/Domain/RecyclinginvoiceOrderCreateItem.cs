using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecyclinginvoiceOrderCreateItem Data Structure.
    /// </summary>
    [Serializable]
    public class RecyclinginvoiceOrderCreateItem : AopObject
    {
        /// <summary>
        /// 商品ID，传值为新增商品接口返回的商品ID
        /// </summary>
        [XmlElement("company_item_id")]
        public string CompanyItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 数量（整数最长七位，小数最长六位）
        /// </summary>
        [XmlElement("item_num")]
        public string ItemNum { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [XmlElement("item_spec")]
        public string ItemSpec { get; set; }

        /// <summary>
        /// 金额（元，整数最长七位，小数最长两位）
        /// </summary>
        [XmlElement("item_total_amount")]
        public string ItemTotalAmount { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("item_unit")]
        public string ItemUnit { get; set; }

        /// <summary>
        /// 单价（元，整数最长七位，小数最长六位）
        /// </summary>
        [XmlElement("item_unit_amount")]
        public string ItemUnitAmount { get; set; }

        /// <summary>
        /// 税收分类编码，根据税务机关编制的税收分类编码表传值
        /// </summary>
        [XmlElement("tax_code")]
        public string TaxCode { get; set; }
    }
}
