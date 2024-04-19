using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountMemberBatchqueryResponse.
    /// </summary>
    public class AlipayFundJointaccountMemberBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 员工列表
        /// </summary>
        [XmlArray("member_list")]
        [XmlArrayItem("joint_account_member_d_t_o")]
        public List<JointAccountMemberDTO> MemberList { get; set; }

        /// <summary>
        /// 当前页数，使用游标方式查询时，没有该字段
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 当前记录数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page_count")]
        public string TotalPageCount { get; set; }
    }
}
