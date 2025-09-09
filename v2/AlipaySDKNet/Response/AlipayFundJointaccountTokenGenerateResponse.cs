using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountTokenGenerateResponse.
    /// </summary>
    public class AlipayFundJointaccountTokenGenerateResponse : AopResponse
    {
        /// <summary>
        /// 转换存储后的token值
        /// </summary>
        [XmlElement("token_key")]
        public string TokenKey { get; set; }
    }
}
