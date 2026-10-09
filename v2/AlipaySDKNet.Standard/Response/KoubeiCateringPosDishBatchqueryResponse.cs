using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosDishBatchqueryResponse.
    /// </summary>
    public class KoubeiCateringPosDishBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 菜谱中的菜品的列表
        /// </summary>
        [XmlElement("cook_dish")]
        public PosCookDishQryModel CookDish { get; set; }
    }
}
