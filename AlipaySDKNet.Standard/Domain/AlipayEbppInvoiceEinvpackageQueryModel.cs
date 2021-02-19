using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEinvpackageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceEinvpackageQueryModel : AopObject
    {
        /// <summary>
        /// 加密过的uid。获取详情参见 <a href="https://opendocs.alipay.com/open/017fwh">"推"模式发票报销</a>。
        /// </summary>
        [XmlElement("encrypted_uid")]
        public string EncryptedUid { get; set; }

        /// <summary>
        /// 发票包id。获取详情参见 <a href="https://opendocs.alipay.com/open/017fwh">"推"模式发票报销</a>。
        /// </summary>
        [XmlElement("package_id")]
        public string PackageId { get; set; }
    }
}
