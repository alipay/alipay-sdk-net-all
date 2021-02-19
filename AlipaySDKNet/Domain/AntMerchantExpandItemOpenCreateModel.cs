using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandItemOpenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemOpenCreateModel : AopObject
    {
        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品扩展信息（具体KEY请参见产品文档）。 小程序订单中心场景参见 https://opendocs.alipay.com/mini/00u9ga
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("item_ext_info")]
        public List<ItemExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 素材列表（最多3个），素材内容为素材key（素材key获取方式参照：https://opendocs.alipay.com/apis/api_4/alipay.merchant.item.file.upload）
        /// </summary>
        [XmlArray("material_list")]
        [XmlArrayItem("material_create_info")]
        public List<MaterialCreateInfo> MaterialList { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品属性列表
        /// </summary>
        [XmlArray("property_list")]
        [XmlArrayItem("item_property_info")]
        public List<ItemPropertyInfo> PropertyList { get; set; }

        /// <summary>
        /// 业务场景码。 小程序订单中心场景固定为 APP_ORDER。
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 商品SKU列表（至少1个，最多20个）
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("sku_create_info")]
        public List<SkuCreateInfo> SkuList { get; set; }

        /// <summary>
        /// 商品所属标准类目ID，当 type 为STANDARD_GOODS（标品）时必填。  请填入 https://opendocs.alipay.com/mini/011lxt  小程序商品类目表中三级类目ID。
        /// </summary>
        [XmlElement("standard_category_id")]
        public string StandardCategoryId { get; set; }

        /// <summary>
        /// 商品归属主体ID 例：商品归属主体类型target_type为店铺，则商品归属主体ID为店铺ID（支付宝侧店铺ID）；归属主体类型target_type为小程序，则归属主体ID为小程序ID
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商品归属主体类型。枚举如下： 5：店铺。 8：小程序。
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 商品类型。枚举支持： STANDARD_GOODS：标品，一般是具有明确、标准规格、型号、参数的商品，如：手机、数码产品、大多数的家电 。 NON_STANDARD_GOODS：非标品等，，则是在这些方面没有统一的行业标准和参数规格的商品，如：服装、鞋袜等。
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
