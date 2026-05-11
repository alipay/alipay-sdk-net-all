using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CoreMaterialStockDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CoreMaterialStockDetail : AopObject
    {
        /// <summary>
        /// 移动时间
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 库存id
        /// </summary>
        [XmlElement("core_material_stock_id")]
        public string CoreMaterialStockId { get; set; }

        /// <summary>
        /// 核心原材料ID
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 核心原材料名称
        /// </summary>
        [XmlElement("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 备注信息，由供应商自定义
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 移动数量,单位个
        /// </summary>
        [XmlElement("move_amount")]
        public long MoveAmount { get; set; }

        /// <summary>
        /// 移动类型
        /// </summary>
        [XmlElement("move_type")]
        public string MoveType { get; set; }

        /// <summary>
        /// 关联外部单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 库存类型
        /// </summary>
        [XmlElement("stock_type")]
        public string StockType { get; set; }

        /// <summary>
        /// 仓库ID（由蚂蚁分配）
        /// </summary>
        [XmlElement("warehouse_id")]
        public string WarehouseId { get; set; }

        /// <summary>
        /// 仓库名称，由蚂蚁指定
        /// </summary>
        [XmlElement("warehouse_name")]
        public string WarehouseName { get; set; }
    }
}
