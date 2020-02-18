using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishAreaSyncResponse.
    /// </summary>
    public class KoubeiCateringDishAreaSyncResponse : AopResponse
    {
        /// <summary>
        /// 餐区餐台模型
        /// </summary>
        [XmlElement("kb_dish_area")]
        public KbdishAreaInfo KbDishArea { get; set; }
    }
}
