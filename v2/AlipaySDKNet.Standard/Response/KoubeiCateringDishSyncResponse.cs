using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishSyncResponse.
    /// </summary>
    public class KoubeiCateringDishSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回的菜品模型
        /// </summary>
        [XmlElement("kb_dish_info")]
        public KbdishInfo KbDishInfo { get; set; }
    }
}
