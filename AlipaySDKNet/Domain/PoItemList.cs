using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PoItemList Data Structure.
    /// </summary>
    [Serializable]
    public class PoItemList : AopObject
    {
        /// <summary>
        /// amount，用于三方商城创建PO指令，由调用方传入
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// currency，用于三方商城创建PO指令，由调用方传入
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// po_item_id，用于三方商城创建PO指令，由调用方传入
        /// </summary>
        [XmlElement("po_item_id")]
        public long PoItemId { get; set; }

        /// <summary>
        /// po_item_num，用于三方商城创建PO指令，由调用方传入
        /// </summary>
        [XmlElement("po_item_num")]
        public long PoItemNum { get; set; }

        /// <summary>
        /// pr_item_id，用于三方商城创建PO指令，由调用方传入
        /// </summary>
        [XmlElement("pr_item_id")]
        public string PrItemId { get; set; }

        /// <summary>
        /// pr_number，用于三方商城创建PO指令，由调用方传入
        /// </summary>
        [XmlElement("pr_number")]
        public string PrNumber { get; set; }

        /// <summary>
        /// quantity，用于三方商城创建PO指令，由调用方传入
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// receiver_address，用于三方商城创建PO指令，由调用方传入
        /// </summary>
        [XmlElement("receiver_address")]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// receiver_name，用于三方商城创建PO指令，由调用方传入
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// receiver_phone，用于三方商城创建PO指令，由调用方传入
        /// </summary>
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// source_product_id，用于三方商城创建PO指令，由调用方传入
        /// </summary>
        [XmlElement("source_product_id")]
        public string SourceProductId { get; set; }

        /// <summary>
        /// source_sku_id，用于三方商城创建PO指令，由调用方传入
        /// </summary>
        [XmlElement("source_sku_id")]
        public string SourceSkuId { get; set; }

        /// <summary>
        /// unit_price，用于三方商城创建PO指令，由调用方传入
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
