using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishCommgroupQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishCommgroupQueryModel : AopObject
    {
        /// <summary>
        /// 需要查询的组id
        /// </summary>
        [XmlElement("comm_group_id")]
        public string CommGroupId { get; set; }

        /// <summary>
        /// 查询页码，表示第几页
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小，表示每页查询数量，不超过50
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
