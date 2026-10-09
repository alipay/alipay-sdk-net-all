using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishCookSyncResponse.
    /// </summary>
    public class KoubeiCateringDishCookSyncResponse : AopResponse
    {
        /// <summary>
        /// 操作后返回整个模型
        /// </summary>
        [XmlElement("kb_dish_cook")]
        public KbdishCookInfo KbDishCook { get; set; }
    }
}
