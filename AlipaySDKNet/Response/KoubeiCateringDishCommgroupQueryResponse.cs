using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishCommgroupQueryResponse.
    /// </summary>
    public class KoubeiCateringDishCommgroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 客制化组分页信息
        /// </summary>
        [XmlElement("kb_dish_group_page_info")]
        public PaginationCommGroup KbDishGroupPageInfo { get; set; }
    }
}
