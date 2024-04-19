using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountListQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountListQueryResponse : AopResponse
    {
        /// <summary>
        /// 共同账户列表
        /// </summary>
        [XmlArray("account_list")]
        [XmlArrayItem("joint_account_d_t_o")]
        public List<JointAccountDTO> AccountList { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
