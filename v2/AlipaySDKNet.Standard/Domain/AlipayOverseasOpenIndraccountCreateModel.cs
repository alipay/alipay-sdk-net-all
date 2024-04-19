using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenIndraccountCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenIndraccountCreateModel : AopObject
    {
        /// <summary>
        /// 机构详细信息
        /// </summary>
        [XmlElement("beneficiary_detail")]
        public string BeneficiaryDetail { get; set; }

        /// <summary>
        /// 机构账单信息
        /// </summary>
        [XmlElement("beneficiary_receipt_method")]
        public string BeneficiaryReceiptMethod { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 业务场景类型
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }
    }
}
