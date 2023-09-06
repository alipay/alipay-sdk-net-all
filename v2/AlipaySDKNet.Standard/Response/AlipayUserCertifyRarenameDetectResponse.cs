using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertifyRarenameDetectResponse.
    /// </summary>
    public class AlipayUserCertifyRarenameDetectResponse : AopResponse
    {
        /// <summary>
        /// 业务结果码，取值: IS_RARE_NAME(是特殊名字), NOT_RARE_NAME(不是特殊名字), POSSIBLE_RARE_NAME(可能是特殊名字)。
        /// </summary>
        [XmlElement("ret_code")]
        public string RetCode { get; set; }
    }
}
