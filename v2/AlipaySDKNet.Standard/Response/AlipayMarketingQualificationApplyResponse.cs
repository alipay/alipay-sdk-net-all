using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingQualificationApplyResponse.
    /// </summary>
    public class AlipayMarketingQualificationApplyResponse : AopResponse
    {
        /// <summary>
        /// 锚定物id
        /// </summary>
        [XmlElement("anchor_id")]
        public string AnchorId { get; set; }

        /// <summary>
        /// 锚定物实例id
        /// </summary>
        [XmlElement("anchor_instance_id")]
        public string AnchorInstanceId { get; set; }

        /// <summary>
        /// 资格ID
        /// </summary>
        [XmlElement("qual_id")]
        public string QualId { get; set; }

        /// <summary>
        /// 资格实例ID
        /// </summary>
        [XmlElement("qual_instance_id")]
        public string QualInstanceId { get; set; }

        /// <summary>
        /// 锚定物资格券信息
        /// </summary>
        [XmlElement("voucher")]
        public QualificationVoucherDTO Voucher { get; set; }
    }
}
