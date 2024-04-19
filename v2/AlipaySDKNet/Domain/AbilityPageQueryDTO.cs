using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AbilityPageQueryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AbilityPageQueryDTO : AopObject
    {
        /// <summary>
        /// 搜索运营列表的分页数据
        /// </summary>
        [XmlArray("page_data")]
        [XmlArrayItem("search_ability_order_data")]
        public List<SearchAbilityOrderData> PageData { get; set; }

        /// <summary>
        /// 当前页码，默认第一页
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页记录数，默认10
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_number")]
        public long TotalNumber { get; set; }
    }
}
