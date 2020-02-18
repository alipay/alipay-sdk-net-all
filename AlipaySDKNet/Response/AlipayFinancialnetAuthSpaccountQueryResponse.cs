using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthSpaccountQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthSpaccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 机构专户信息列表
        /// </summary>
        [XmlArray("account_info")]
        [XmlArrayItem("sp_account_info")]
        public List<SpAccountInfo> AccountInfo { get; set; }

        /// <summary>
        /// 调用finauth服务失败时返回的错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 调用finauth失败时返回的错误描述
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 调用finauth查询机构专户信息是否成功
        /// </summary>
        [XmlElement("is_success")]
        public string IsSuccess { get; set; }
    }
}
