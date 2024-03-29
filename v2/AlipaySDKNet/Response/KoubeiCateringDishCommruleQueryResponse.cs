using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishCommruleQueryResponse.
    /// </summary>
    public class KoubeiCateringDishCommruleQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回的数据集合
        /// </summary>
        [XmlElement("kbdish_comm_rule_info_list")]
        public KbdishCommRuleInfo KbdishCommRuleInfoList { get; set; }

        /// <summary>
        /// 表示当前页码
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 表示每页条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 数据总条数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public string TotalPage { get; set; }
    }
}
