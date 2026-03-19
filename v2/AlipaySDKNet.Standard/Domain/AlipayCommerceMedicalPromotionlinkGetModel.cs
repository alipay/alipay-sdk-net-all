using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalPromotionlinkGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalPromotionlinkGetModel : AopObject
    {
        /// <summary>
        /// 好大夫医生ID
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 小B用户ID
        /// </summary>
        [XmlElement("promotion_u_id")]
        public string PromotionUId { get; set; }
    }
}
