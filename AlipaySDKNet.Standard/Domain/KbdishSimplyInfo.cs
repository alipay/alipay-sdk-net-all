using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishSimplyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishSimplyInfo : AopObject
    {
        /// <summary>
        /// 加购描述
        /// </summary>
        [XmlElement("add_remark")]
        public string AddRemark { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("catetory_name")]
        public string CatetoryName { get; set; }

        /// <summary>
        /// 类目的排序值
        /// </summary>
        [XmlElement("catetory_sort")]
        public string CatetorySort { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [XmlElement("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 商品图片，需要先调用素材的图片上传api得到图片id
        /// </summary>
        [XmlElement("dmg_img")]
        public string DmgImg { get; set; }

        /// <summary>
        /// 套餐组列表
        /// </summary>
        [XmlArray("group_list")]
        [XmlArrayItem("kbdish_group_simplify_info")]
        public List<KbdishGroupSimplifyInfo> GroupList { get; set; }

        /// <summary>
        /// 加料组列表
        /// </summary>
        [XmlArray("material_group_list")]
        [XmlArrayItem("kbdish_material_simplify_info")]
        public List<KbdishMaterialSimplifyInfo> MaterialGroupList { get; set; }

        /// <summary>
        /// 起点份数，需要保证是数字类型
        /// </summary>
        [XmlElement("min_serving")]
        public string MinServing { get; set; }

        /// <summary>
        /// 外部菜品id
        /// </summary>
        [XmlElement("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 如果此菜专属某个门店设置此值，和shop_id二选一
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 属性列表
        /// </summary>
        [XmlArray("property_list")]
        [XmlArrayItem("kbdish_property_simplify_info")]
        public List<KbdishPropertySimplifyInfo> PropertyList { get; set; }

        /// <summary>
        /// 菜品描述
        /// </summary>
        [XmlElement("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// sku列表
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("kbdish_sku_simplify_info")]
        public List<KbdishSkuSimplifyInfo> SkuList { get; set; }

        /// <summary>
        /// 菜品状态，open 启动 stop 停用
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        [XmlElement("sub_name")]
        public string SubName { get; set; }

        /// <summary>
        /// 菜品描述
        /// </summary>
        [XmlElement("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 菜品类型，口碑枚举定义 single:单品;packages：套餐
        /// </summary>
        [XmlElement("type_big")]
        public string TypeBig { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
