using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAssetBomQueryResponse.
    /// </summary>
    public class AntMerchantExpandAssetBomQueryResponse : AopResponse
    {
        /// <summary>
        /// 物料清单信息
        /// </summary>
        [XmlElement("asset_bom")]
        public AssetBom AssetBom { get; set; }
    }
}
