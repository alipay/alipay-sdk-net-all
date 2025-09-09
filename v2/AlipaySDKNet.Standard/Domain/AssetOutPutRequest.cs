using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetOutPutRequest Data Structure.
    /// </summary>
    [Serializable]
    public class AssetOutPutRequest : AopObject
    {
        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 凭证号
        /// </summary>
        [XmlElement("out_voucher_id")]
        public string OutVoucherId { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("tele_no")]
        public string TeleNo { get; set; }
    }
}
