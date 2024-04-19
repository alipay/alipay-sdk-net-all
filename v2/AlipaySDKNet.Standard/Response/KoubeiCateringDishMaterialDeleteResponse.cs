using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishMaterialDeleteResponse.
    /// </summary>
    public class KoubeiCateringDishMaterialDeleteResponse : AopResponse
    {
        /// <summary>
        /// 菜品加料通用模型返回
        /// </summary>
        [XmlElement("kb_dish_material_info")]
        public KbdishMaterialInfo KbDishMaterialInfo { get; set; }
    }
}
