using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataUseralternatedoctorQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataUseralternatedoctorQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 已备选医生list<好大夫Id、医生内部Id、备选操作时间>
        /// </summary>
        [XmlArray("alternate_doctor_list")]
        [XmlArrayItem("user_alternate_doctor")]
        public List<UserAlternateDoctor> AlternateDoctorList { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id_open_id")]
        public string UserIdOpenId { get; set; }
    }
}
