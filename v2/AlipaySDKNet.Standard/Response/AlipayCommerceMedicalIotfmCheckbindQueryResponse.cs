using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIotfmCheckbindQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalIotfmCheckbindQueryResponse : AopResponse
    {
        /// <summary>
        /// 主账户是否有绑定亲情账户
        /// </summary>
        [XmlElement("has_bind_fm")]
        public bool HasBindFm { get; set; }
    }
}
