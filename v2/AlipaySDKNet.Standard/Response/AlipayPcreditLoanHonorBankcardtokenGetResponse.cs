using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorBankcardtokenGetResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorBankcardtokenGetResponse : AopResponse
    {
        /// <summary>
        /// 查询银行卡列表token
        /// </summary>
        [XmlElement("api_token")]
        public string ApiToken { get; set; }

        /// <summary>
        /// 有效截止时间, 格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("valid_time")]
        public string ValidTime { get; set; }
    }
}
