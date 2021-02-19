using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountBillQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountBillQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回账单列表
        /// </summary>
        [XmlArray("bill_list")]
        [XmlArrayItem("joint_account_bill_detail_d_t_o")]
        public List<JointAccountBillDetailDTO> BillList { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

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

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
