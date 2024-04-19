using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishMaterialInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishMaterialInfo : AopObject
    {
        /// <summary>
        /// 加价金额，最小加价金额0
        /// </summary>
        [XmlElement("add_price")]
        public string AddPrice { get; set; }

        /// <summary>
        /// 创建人，在新增时必传
        /// </summary>
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 扩展字段,星巴克萃取方式需设置特殊字段"StandardStandardAliFilter":{"StandardCoffeeAliFilter":"aaaaaa","DecafCoffeeAliFilter":"bbbbbb" }   key为out_material_id  value为标准/低因对应的新的poskey 组成的json
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 加料的描述字段
        /// </summary>
        [XmlElement("material_desc")]
        public string MaterialDesc { get; set; }

        /// <summary>
        /// 加料id，加料的唯一标识。  新增时该项不用传，修改删除时必传。
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 口碑的加料图片id
        /// </summary>
        [XmlElement("material_img")]
        public string MaterialImg { get; set; }

        /// <summary>
        /// 加料的名称
        /// </summary>
        [XmlElement("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// SHOP/PID。代表加料类型是门店或者商户。
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 表示单个菜品加料最多可以加料的份数
        /// </summary>
        [XmlElement("max_num")]
        public string MaxNum { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 外部isv的加料id
        /// </summary>
        [XmlElement("out_material_id")]
        public string OutMaterialId { get; set; }

        /// <summary>
        /// 公共字段，根据materialType的类型，这里填入商户id或者口碑门店id。
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 加料的单位id
        /// </summary>
        [XmlElement("unit_id")]
        public string UnitId { get; set; }

        /// <summary>
        /// 修改人，在新增和修改，删除时必传
        /// </summary>
        [XmlElement("update_user")]
        public string UpdateUser { get; set; }
    }
}
