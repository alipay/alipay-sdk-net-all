using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertifyRarenameTransferResponse.
    /// </summary>
    public class AlipayUserCertifyRarenameTransferResponse : AopResponse
    {
        /// <summary>
        /// 结果姓名列表，多个姓名之间用逗号分隔。
        /// </summary>
        [XmlElement("ret_name_list")]
        public string RetNameList { get; set; }
    }
}
