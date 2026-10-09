using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishConditionBatchqueryResponse.
    /// </summary>
    public class KoubeiCateringDishConditionBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 菜品分页信息
        /// </summary>
        [XmlElement("kb_dish_page_info")]
        public PaginationDish KbDishPageInfo { get; set; }
    }
}
