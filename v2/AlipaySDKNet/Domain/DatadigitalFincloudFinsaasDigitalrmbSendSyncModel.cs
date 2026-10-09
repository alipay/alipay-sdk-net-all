using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasDigitalrmbSendSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasDigitalrmbSendSyncModel : AopObject
    {
        /// <summary>
        /// cred_id+用户凭证ID+唯一
        /// </summary>
        [XmlElement("cred_id")]
        public string CredId { get; set; }

        /// <summary>
        /// person_id+用户唯一标识+唯一
        /// </summary>
        [XmlElement("person_id")]
        public string PersonId { get; set; }

        /// <summary>
        /// phone_no+用户手机号+唯一
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }
    }
}
