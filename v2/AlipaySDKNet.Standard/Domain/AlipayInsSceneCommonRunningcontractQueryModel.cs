using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneCommonRunningcontractQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneCommonRunningcontractQueryModel : AopObject
    {
        /// <summary>
        /// 合作商ID，由蚂蚁保统一分配
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 由蚂蚁保提供，合作的产品的唯一标识
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }

        /// <summary>
        /// 如果是订购人纬度，该值为订购用户的ID；如果是商品纬度，该值为订购商品的ID
        /// </summary>
        [XmlElement("subject_id")]
        public string SubjectId { get; set; }

        /// <summary>
        /// 订购主体类型，蚂蚁保合作时确定
        /// </summary>
        [XmlElement("subject_type")]
        public string SubjectType { get; set; }

        /// <summary>
        /// 订购用户的ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
