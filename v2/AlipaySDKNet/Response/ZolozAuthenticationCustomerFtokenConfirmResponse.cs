using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerFtokenConfirmResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerFtokenConfirmResponse : AopResponse
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("retcode")]
        public string Retcode { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [XmlElement("retmsg")]
        public string Retmsg { get; set; }

        /// <summary>
        /// ftoken与uid的映射关系
        /// </summary>
        [XmlArray("uids")]
        [XmlArrayItem("ftoken_info_result")]
        public List<FtokenInfoResult> Uids { get; set; }
    }
}
