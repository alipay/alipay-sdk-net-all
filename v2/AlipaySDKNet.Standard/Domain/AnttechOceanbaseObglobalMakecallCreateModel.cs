using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalMakecallCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalMakecallCreateModel : AopObject
    {
        /// <summary>
        /// 发起外呼的请求体
        /// </summary>
        [XmlElement("make_call_request")]
        public MakeCallRequest MakeCallRequest { get; set; }
    }
}
