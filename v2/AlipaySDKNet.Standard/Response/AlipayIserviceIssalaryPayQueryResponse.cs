using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIssalaryPayQueryResponse.
    /// </summary>
    public class AlipayIserviceIssalaryPayQueryResponse : AopResponse
    {
        /// <summary>
        /// 小二发薪结果列表
        /// </summary>
        [XmlArray("user_pay_details")]
        [XmlArrayItem("user_pay_detail")]
        public List<UserPayDetail> UserPayDetails { get; set; }
    }
}
