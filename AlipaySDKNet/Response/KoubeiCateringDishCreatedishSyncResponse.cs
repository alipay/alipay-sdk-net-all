using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishCreatedishSyncResponse.
    /// </summary>
    public class KoubeiCateringDishCreatedishSyncResponse : AopResponse
    {
        /// <summary>
        /// 口碑菜品id
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 是否需要重试
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
