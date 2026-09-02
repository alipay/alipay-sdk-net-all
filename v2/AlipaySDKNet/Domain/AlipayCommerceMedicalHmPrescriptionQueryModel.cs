using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHmPrescriptionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHmPrescriptionQueryModel : AopObject
    {
        /// <summary>
        /// 不传则查用户当前有效活动
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("channels")]
        [XmlArrayItem("string")]
        public List<string> Channels { get; set; }

        /// <summary>
        /// 用户支付宝 UID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户支付宝 UID
        /// </summary>
        [XmlElement("user_uid")]
        public string UserUid { get; set; }
    }
}
