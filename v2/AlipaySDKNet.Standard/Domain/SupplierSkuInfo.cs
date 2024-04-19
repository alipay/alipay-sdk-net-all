using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupplierSkuInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SupplierSkuInfo : AopObject
    {
        /// <summary>
        /// 商品属性集合{"WEIGHT": "100丝","SIZE": "120mm*170mm","SELECTSIDED": "单面"}
        /// </summary>
        [XmlArray("attr_collect")]
        [XmlArrayItem("supplier_item_attr_field")]
        public List<SupplierItemAttrField> AttrCollect { get; set; }

        /// <summary>
        /// 商品条形码
        /// </summary>
        [XmlElement("bar_code")]
        public string BarCode { get; set; }

        /// <summary>
        /// 是否需要批次管理(Y是N否 ;默认为N)
        /// </summary>
        [XmlElement("batch_mgmt_flag")]
        public string BatchMgmtFlag { get; set; }

        /// <summary>
        /// 品牌代码
        /// </summary>
        [XmlElement("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 商品类别Id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品类别名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 是否易碎品, Y/N (默认为N)
        /// </summary>
        [XmlElement("fragile_flag")]
        public string FragileFlag { get; set; }

        /// <summary>
        /// 是否易碎品, Y/N (默认为N)
        /// </summary>
        [XmlElement("hazardous_flag")]
        public string HazardousFlag { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 如果是上架到多个渠道，多个渠道编码之间用逗号隔开。
        /// </summary>
        [XmlElement("item_listing_channels")]
        public string ItemListingChannels { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品类型 (ZC=正常商品, FX=分销商品, ZH=组合商品, ZP=赠品, BC=包材, HC=耗材, FL=辅料, XN=虚拟品, FS=附属品, CC=残次品, OTHER=其它) 只传英文编码
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 是否液体, Y/N, (默认为N)
        /// </summary>
        [XmlElement("liquid_flag")]
        public string LiquidFlag { get; set; }

        /// <summary>
        /// 保质期禁售天数(单位：天)
        /// </summary>
        [XmlElement("lockup_lifecycle")]
        public long LockupLifecycle { get; set; }

        /// <summary>
        /// 保质期禁收天数(单位：天)
        /// </summary>
        [XmlElement("reject_lifecycle")]
        public long RejectLifecycle { get; set; }

        /// <summary>
        /// 保质期 (单位：小时)
        /// </summary>
        [XmlElement("shelf_life")]
        public long ShelfLife { get; set; }

        /// <summary>
        /// 是否需要保质期管理, Y/N (默认为N)
        /// </summary>
        [XmlElement("shelf_life_mgmt_flag")]
        public string ShelfLifeMgmtFlag { get; set; }

        /// <summary>
        /// 是否需要串号管理, Y/N (默认为N)
        /// </summary>
        [XmlElement("snmgmt_flag")]
        public string SnmgmtFlag { get; set; }
    }
}
