using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceGasBarcodeInstCertifyResponse.
    /// </summary>
    public class AlipayCommerceGasBarcodeInstCertifyResponse : AopResponse
    {
        /// <summary>
        /// 机构支付验证动态码
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 支付过程中，保存在支付宝系统的机构会员ID，用于机构二次核验，如核验失败，将返回该member_no,成功则不返回
        /// </summary>
        [XmlElement("member_no")]
        public string MemberNo { get; set; }

        /// <summary>
        /// 碰一碰设备sn编号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
