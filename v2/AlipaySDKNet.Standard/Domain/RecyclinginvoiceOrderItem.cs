using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecyclinginvoiceOrderItem Data Structure.
    /// </summary>
    [Serializable]
    public class RecyclinginvoiceOrderItem : AopObject
    {
        /// <summary>
        /// 企业商品ID
        /// </summary>
        [XmlElement("company_item_id")]
        public string CompanyItemId { get; set; }

        /// <summary>
        /// 商品服务简称
        /// </summary>
        [XmlElement("item_category_name")]
        public string ItemCategoryName { get; set; }

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
        /// 金额（元，整数最长七位，小数最长两位）
        /// </summary>
        [XmlElement("item_total_amount")]
        public string ItemTotalAmount { get; set; }

        /// <summary>
        /// 单价（元，整数最长七位，小数最长六位）
        /// </summary>
        [XmlElement("item_unit_amount")]
        public string ItemUnitAmount { get; set; }

        /// <summary>
        /// 订单明细ID
        /// </summary>
        [XmlElement("order_item_id")]
        public string OrderItemId { get; set; }

        /// <summary>
        /// 税收分类编码
        /// </summary>
        [XmlElement("tax_code")]
        public string TaxCode { get; set; }
    }
}
