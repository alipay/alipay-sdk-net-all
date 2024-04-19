using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KmsBakingInventoryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class KmsBakingInventoryDTO : AopObject
    {
        /// <summary>
        /// 累计库存；本字段不能为负数
        /// </summary>
        [XmlElement("accumulate_inventory")]
        public string AccumulateInventory { get; set; }

        /// <summary>
        /// 表示这条数据的唯一id，主要用于后续同步了重复数据以后去重，或者用于修复之前同步的问题数据。 建议生成规则：根据shop_id+sku_batch+operate_name+operate_time生成hash值
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 操作后库存
        /// </summary>
        [XmlElement("ending_inventory")]
        public string EndingInventory { get; set; }

        /// <summary>
        /// 操作后位置，传中文或id均可
        /// </summary>
        [XmlElement("ending_position")]
        public string EndingPosition { get; set; }

        /// <summary>
        /// 操作前库存
        /// </summary>
        [XmlElement("opening_inventory")]
        public string OpeningInventory { get; set; }

        /// <summary>
        /// 操作名称；若为示例中包含的操作类型请按示例值传递，否则可以传递自定义的值但必须与示例值不同
        /// </summary>
        [XmlElement("operation_name")]
        public string OperationName { get; set; }

        /// <summary>
        /// 操作数量，可以为整数或者小数但不能为负数
        /// </summary>
        [XmlElement("operation_num")]
        public string OperationNum { get; set; }

        /// <summary>
        /// 操作时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("operation_time")]
        public string OperationTime { get; set; }

        /// <summary>
        /// 操作员，传中文或id均可
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// sku批次
        /// </summary>
        [XmlElement("sku_batch")]
        public string SkuBatch { get; set; }

        /// <summary>
        /// 口碑skuId，需要通过口碑菜品同步获取
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 操作前位置，传中文或id均可
        /// </summary>
        [XmlElement("starting_position")]
        public string StartingPosition { get; set; }
    }
}
