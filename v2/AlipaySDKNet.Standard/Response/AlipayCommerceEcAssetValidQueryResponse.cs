using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcAssetValidQueryResponse.
    /// </summary>
    public class AlipayCommerceEcAssetValidQueryResponse : AopResponse
    {
        /// <summary>
        /// 签约类型
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
