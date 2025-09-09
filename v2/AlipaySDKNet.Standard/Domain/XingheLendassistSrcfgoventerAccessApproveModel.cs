using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistSrcfgoventerAccessApproveModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistSrcfgoventerAccessApproveModel : AopObject
    {
        /// <summary>
        /// 需审核的政企单位统一社会信用代码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 需审核的政企单位名称
        /// </summary>
        [XmlElement("gov_enter_name")]
        public string GovEnterName { get; set; }

        /// <summary>
        /// 客户id，平台为接入客户分配
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 唯一标识政企单位准入审核请求
        /// </summary>
        [XmlElement("out_bsn_no")]
        public string OutBsnNo { get; set; }

        /// <summary>
        /// 业务所属产品，平台为业务分配
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }
    }
}
