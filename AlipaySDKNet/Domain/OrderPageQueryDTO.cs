using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderPageQueryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderPageQueryDTO : AopObject
    {
        /// <summary>
        /// 审核单数据信息
        /// </summary>
        [XmlArray("page_data")]
        [XmlArrayItem("apply_order_data")]
        public List<ApplyOrderData> PageData { get; set; }

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
