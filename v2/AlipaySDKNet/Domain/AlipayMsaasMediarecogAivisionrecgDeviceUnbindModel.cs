using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAivisionrecgDeviceUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogAivisionrecgDeviceUnbindModel : AopObject
    {
        /// <summary>
        /// 激活码
        /// </summary>
        [XmlElement("activation_code")]
        public string ActivationCode { get; set; }

        /// <summary>
        /// 服务商ID
        /// </summary>
        [XmlElement("isv_id")]
        public string IsvId { get; set; }
    }
}
