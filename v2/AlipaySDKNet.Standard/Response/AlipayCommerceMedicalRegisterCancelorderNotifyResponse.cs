using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterCancelorderNotifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalRegisterCancelorderNotifyResponse : AopResponse
    {
        /// <summary>
        /// 取消完成
        /// </summary>
        [XmlElement("cancel_msg")]
        public string CancelMsg { get; set; }
    }
}
