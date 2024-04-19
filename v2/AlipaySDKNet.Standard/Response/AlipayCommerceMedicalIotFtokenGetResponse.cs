using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIotFtokenGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalIotFtokenGetResponse : AopResponse
    {
        /// <summary>
        /// 是否亲情码值，"1"代表是亲情码值
        /// </summary>
        [XmlElement("fm_flag")]
        public string FmFlag { get; set; }

        /// <summary>
        /// 用户刷脸ftoken
        /// </summary>
        [XmlElement("ftoken")]
        public string Ftoken { get; set; }
    }
}
