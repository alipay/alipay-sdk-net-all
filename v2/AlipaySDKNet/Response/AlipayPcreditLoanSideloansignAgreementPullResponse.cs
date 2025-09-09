using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanSideloansignAgreementPullResponse.
    /// </summary>
    public class AlipayPcreditLoanSideloansignAgreementPullResponse : AopResponse
    {
        /// <summary>
        /// 曝光返回需要签署的协议列表, 类型为List<AgreementView>
        /// </summary>
        [XmlArray("agreement_list")]
        [XmlArrayItem("agreement_view")]
        public List<AgreementView> AgreementList { get; set; }

        /// <summary>
        /// 协议曝光结果透传给下游业务接口的信息
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 表示当前请求处理状态
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// returnCode为FAIL或者NEED_RETRY状态下，返回具体详细子级错误码
        /// </summary>
        [XmlElement("return_sub_code")]
        public string ReturnSubCode { get; set; }

        /// <summary>
        /// return_code为FAIL时, 需要返回return_sub_message以详细描述失败原因，方便双方定位问题
        /// </summary>
        [XmlElement("return_sub_message")]
        public string ReturnSubMessage { get; set; }
    }
}
