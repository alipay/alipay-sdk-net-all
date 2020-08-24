using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoPreconsultQueryResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoPreconsultQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [XmlElement("admittance")]
        public bool Admittance { get; set; }
    }
}
