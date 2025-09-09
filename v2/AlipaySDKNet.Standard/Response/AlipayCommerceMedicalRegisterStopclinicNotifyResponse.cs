using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterStopclinicNotifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalRegisterStopclinicNotifyResponse : AopResponse
    {
        /// <summary>
        /// 处理成功后，返回处理的排班id
        /// </summary>
        [XmlElement("register_id")]
        public string RegisterId { get; set; }
    }
}
