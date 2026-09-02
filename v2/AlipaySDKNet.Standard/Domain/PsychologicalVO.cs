using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PsychologicalVO Data Structure.
    /// </summary>
    [Serializable]
    public class PsychologicalVO : AopObject
    {
        /// <summary>
        /// 履约单号
        /// </summary>
        [XmlElement("fulfillment_no")]
        public string FulfillmentNo { get; set; }

        /// <summary>
        /// 履约状态
        /// </summary>
        [XmlElement("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        /// <summary>
        /// 履约状态描述
        /// </summary>
        [XmlElement("fulfillment_status_desc")]
        public string FulfillmentStatusDesc { get; set; }

        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("fulfillment_type")]
        public string FulfillmentType { get; set; }

        /// <summary>
        /// 患者性别1-男，0-女
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("patient_phone")]
        public string PatientPhone { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
