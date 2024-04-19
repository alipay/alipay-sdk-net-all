using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageItempackageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseResourcepackageItempackageQueryModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("commodity_code")]
        public string CommodityCode { get; set; }
    }
}
