using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundFlexiblestaffingEmployeehomeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundFlexiblestaffingEmployeehomeApplyModel : AopObject
    {
        /// <summary>
        /// 授权跳转类型
        /// </summary>
        [XmlElement("apply_link_type")]
        public string ApplyLinkType { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 跳转渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 零工卡信息
        /// </summary>
        [XmlElement("employee_card_info")]
        public EmployeeCardInfo EmployeeCardInfo { get; set; }

        /// <summary>
        /// 超时时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 主体信息
        /// </summary>
        [XmlElement("principal_info")]
        public ParticipantInfoDTO PrincipalInfo { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 零工卡租赁信息
        /// </summary>
        [XmlElement("rent_agreement_info")]
        public RentServiceInfo RentAgreementInfo { get; set; }
    }
}
