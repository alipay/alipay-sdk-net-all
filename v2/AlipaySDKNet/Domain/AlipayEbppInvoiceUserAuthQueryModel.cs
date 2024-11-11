using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceUserAuthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceUserAuthQueryModel : AopObject
    {
        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 授权查询来源唯一标识
        /// </summary>
        [XmlElement("source_tag")]
        public string SourceTag { get; set; }

        /// <summary>
        /// 用户开票邮箱
        /// </summary>
        [XmlElement("user_email")]
        public string UserEmail { get; set; }
    }
}
