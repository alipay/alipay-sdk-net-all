using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistSrcfgestagelendOutordermappingSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistSrcfgestagelendOutordermappingSyncModel : AopObject
    {
        /// <summary>
        /// 政企员工团购分期授信初审的申请单号
        /// </summary>
        [XmlElement("credit_apply_no")]
        public string CreditApplyNo { get; set; }

        /// <summary>
        /// 平台为接入客户分配
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 网商支用审批的外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 业务所属产品，平台为业务分配
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }
    }
}
