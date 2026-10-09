using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpRoleGetResponse.
    /// </summary>
    public class ZhimaCreditEpRoleGetResponse : AopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 自然人担任 法人/股东/主要管理人员 的企业信息
        /// </summary>
        [XmlElement("company_role")]
        public CompanyRole CompanyRole { get; set; }
    }
}
