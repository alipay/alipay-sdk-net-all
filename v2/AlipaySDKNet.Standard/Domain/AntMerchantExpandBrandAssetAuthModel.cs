using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandBrandAssetAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandBrandAssetAuthModel : AopObject
    {
        /// <summary>
        /// 资产ID，资产类型为账号时传入pid/smid，为门店时传入shopId，为小程序生活号时传入appid
        /// </summary>
        [XmlArray("asset_ids")]
        [XmlArrayItem("string")]
        public List<string> AssetIds { get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 授权人的PID
        /// </summary>
        [XmlElement("authorize_id")]
        public string AuthorizeId { get; set; }

        /// <summary>
        /// 授权类型
        /// </summary>
        [XmlElement("authorize_type")]
        public string AuthorizeType { get; set; }

        /// <summary>
        /// 品牌ID
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 运营主体的pid
        /// </summary>
        [XmlElement("carrier_id")]
        public string CarrierId { get; set; }

        /// <summary>
        /// 授权状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
