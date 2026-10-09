using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcJointaccountbillDetailBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEcJointaccountbillDetailBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 返回账单列表
        /// </summary>
        [XmlArray("bill_list")]
        [XmlArrayItem("joint_account_bill_detail")]
        public List<JointAccountBillDetail> BillList { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 企业ID，和接口入参一致
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        [XmlElement("has_next_page")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 当期页数
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 当期页记录数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
