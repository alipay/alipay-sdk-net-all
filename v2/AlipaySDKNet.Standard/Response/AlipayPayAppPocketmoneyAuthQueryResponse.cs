using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppPocketmoneyAuthQueryResponse.
    /// </summary>
    public class AlipayPayAppPocketmoneyAuthQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权结果，枚举值（ok：授权成功，exist：已经存在）
        /// </summary>
        [XmlElement("auth_result")]
        public string AuthResult { get; set; }

        /// <summary>
        /// 零花钱ID
        /// </summary>
        [XmlElement("change_code_id")]
        public string ChangeCodeId { get; set; }

        /// <summary>
        /// 厂商家长ID
        /// </summary>
        [XmlElement("vendor_parent_id")]
        public string VendorParentId { get; set; }
    }
}
