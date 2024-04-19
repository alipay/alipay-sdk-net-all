using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReserveCustomer Data Structure.
    /// </summary>
    [Serializable]
    public class ReserveCustomer : AopObject
    {
        /// <summary>
        /// 出生日期，格式yyyy-MM-dd
        /// </summary>
        [XmlElement("customer_birthday")]
        public string CustomerBirthday { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("customer_gender")]
        public string CustomerGender { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("customer_identity_no")]
        public string CustomerIdentityNo { get; set; }

        /// <summary>
        /// 婚姻状况
        /// </summary>
        [XmlElement("customer_medical_status")]
        public string CustomerMedicalStatus { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("customer_mobile_phone")]
        public string CustomerMobilePhone { get; set; }

        /// <summary>
        /// 预约人姓名
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }
    }
}
