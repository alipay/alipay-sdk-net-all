using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCreditCreditriskDataPutResponse.
    /// </summary>
    public class AlipayCreditCreditriskDataPutResponse : AopResponse
    {
        /// <summary>
        /// 返回该条数据在网商的唯一ID
        /// </summary>
        [XmlElement("dataid")]
        public string Dataid { get; set; }
    }
}
