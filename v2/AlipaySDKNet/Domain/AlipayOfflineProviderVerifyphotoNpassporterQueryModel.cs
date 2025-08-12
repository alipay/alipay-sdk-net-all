using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderVerifyphotoNpassporterQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderVerifyphotoNpassporterQueryModel : AopObject
    {
        /// <summary>
        /// 字符串
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 字符串
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }
    }
}
