using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingAssetPublishConsultResponse.
    /// </summary>
    public class AlipayMarketingAssetPublishConsultResponse : AopResponse
    {
        /// <summary>
        /// 发放咨询结果，包括权益id、实体id、是否通过等信息
        /// </summary>
        [XmlArray("open_asset_publish_consult_results")]
        [XmlArrayItem("open_asset_publish_consult_result")]
        public List<OpenAssetPublishConsultResult> OpenAssetPublishConsultResults { get; set; }
    }
}
