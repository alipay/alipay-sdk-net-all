using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CoreMaterialPoData Data Structure.
    /// </summary>
    [Serializable]
    public class CoreMaterialPoData : AopObject
    {
        /// <summary>
        /// 已到货数量，单位是个
        /// </summary>
        [XmlElement("delivered_count")]
        public long DeliveredCount { get; set; }

        /// <summary>
        /// 原材料ID
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 原材料名称
        /// </summary>
        [XmlElement("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 备注，由供应商自定义
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 关联外部PO号
        /// </summary>
        [XmlElement("out_po_no")]
        public string OutPoNo { get; set; }

        /// <summary>
        /// 外部供应商ID
        /// </summary>
        [XmlElement("out_supplier_id")]
        public string OutSupplierId { get; set; }

        /// <summary>
        /// 外部供应商名称
        /// </summary>
        [XmlElement("out_supplier_name")]
        public string OutSupplierName { get; set; }

        /// <summary>
        /// PO状态（新增时必填）：CONFIRMED-已确认/SHIPPED-已发货/RECEIVED-已收货/CANCELLED-已取消
        /// </summary>
        [XmlElement("po_status")]
        public string PoStatus { get; set; }

        /// <summary>
        /// PO总数量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 在途数量，单位是个
        /// </summary>
        [XmlElement("transferring_count")]
        public long TransferringCount { get; set; }
    }
}
