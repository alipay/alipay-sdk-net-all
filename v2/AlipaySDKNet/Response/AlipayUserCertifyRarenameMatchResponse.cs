using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertifyRarenameMatchResponse.
    /// </summary>
    public class AlipayUserCertifyRarenameMatchResponse : AopResponse
    {
        /// <summary>
        /// 业务结果码，取值: IS_SAME_RARE_NAME(姓名相同), NOT_SAME_RARE_NAME(姓名不相同), POSSIBLE_SAME_RARE_NAME(可能相同)
        /// </summary>
        [XmlElement("ret_code")]
        public string RetCode { get; set; }
    }
}
