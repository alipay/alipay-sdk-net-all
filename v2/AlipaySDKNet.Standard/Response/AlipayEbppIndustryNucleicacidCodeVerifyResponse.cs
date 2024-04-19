using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryNucleicacidCodeVerifyResponse.
    /// </summary>
    public class AlipayEbppIndustryNucleicacidCodeVerifyResponse : AopResponse
    {
        /// <summary>
        /// 机构业务号，用于关联机构侧存储的用户信息，核验失败时可能为空
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 核酸码值核验结果
        /// </summary>
        [XmlElement("verify_result")]
        public bool VerifyResult { get; set; }
    }
}
