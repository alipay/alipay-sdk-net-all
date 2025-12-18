using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsScenePositionPolicyNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsScenePositionPolicyNotifyModel : AopObject
    {
        /// <summary>
        /// 设备SN码
        /// </summary>
        [XmlElement("device_serial_number")]
        public string DeviceSerialNumber { get; set; }

        /// <summary>
        /// 保司编码
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 外部用户ID
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 合作商编码
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 机构产品码
        /// </summary>
        [XmlElement("prod_no")]
        public string ProdNo { get; set; }
    }
}
