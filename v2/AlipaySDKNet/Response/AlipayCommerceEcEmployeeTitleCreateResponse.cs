using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEmployeeTitleCreateResponse.
    /// </summary>
    public class AlipayCommerceEcEmployeeTitleCreateResponse : AopResponse
    {
        /// <summary>
        /// 抬头失败信息，用来返回批量处理的每一个抬头错误信息
        /// </summary>
        [XmlElement("title_failed_list")]
        public EcEmployeeTitleFailed TitleFailedList { get; set; }
    }
}
