using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodMerchantCreateormodifyResponse.
    /// </summary>
    public class AlipayMerchantSolcreditserviceprodMerchantCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 为空则表示本次修改不需要审核
        /// </summary>
        [XmlElement("review_version_no")]
        public string ReviewVersionNo { get; set; }

        /// <summary>
        /// 为空则表示暂无审核通过版本
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }
    }
}
