using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntProdpaasProductEntryCompleteCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntProdpaasProductEntryCompleteCallbackModel : AopObject
    {
        /// <summary>
        /// 实收数量
        /// </summary>
        [XmlElement("actual_qty")]
        public long ActualQty { get; set; }

        /// <summary>
        /// 批次编码
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 入库单号,入库指令编号
        /// </summary>
        [XmlElement("entry_order_code")]
        public string EntryOrderCode { get; set; }

        /// <summary>
        /// 商品过期日期
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 供应链商品属性集合
        /// </summary>
        [XmlArray("extend_pros")]
        [XmlArrayItem("supplier_item_attr_field")]
        public List<SupplierItemAttrField> ExtendPros { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 外部业务编码
        /// </summary>
        [XmlElement("out_biz_code")]
        public string OutBizCode { get; set; }

        /// <summary>
        /// 生产批号
        /// </summary>
        [XmlElement("produce_code")]
        public string ProduceCode { get; set; }

        /// <summary>
        /// 商品生产日期
        /// </summary>
        [XmlElement("product_date")]
        public string ProductDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 商品序列号
        /// </summary>
        [XmlArray("sn_list")]
        [XmlArrayItem("string")]
        public List<string> SnList { get; set; }

        /// <summary>
        /// 入库单状态: 待入库WAIT_INBOUND，已入库ALL_INBOUND
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 仓库编号,由供应商提供
        /// </summary>
        [XmlElement("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
