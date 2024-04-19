using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsIsvdataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsIsvdataQueryModel : AopObject
    {
        /// <summary>
        /// 根据condition_type，输入相应的查询条件。
        /// </summary>
        [XmlElement("condition_id")]
        public string ConditionId { get; set; }

        /// <summary>
        /// 选择条件查询维度。此参数代表，condition_id的数据类型，请与conditon_id配合一起使用。
        /// </summary>
        [XmlElement("condition_type")]
        public string ConditionType { get; set; }

        /// <summary>
        /// 分页查询的页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页查询一页数据的最大条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 选择需要查询的数据类型，注意：不同的请求参数，会影响返回结果格式。
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }
    }
}
