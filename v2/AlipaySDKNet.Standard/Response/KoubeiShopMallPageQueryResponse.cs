using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiShopMallPageQueryResponse.
    /// </summary>
    public class KoubeiShopMallPageQueryResponse : AopResponse
    {
        /// <summary>
        /// 商圈首页url地址
        /// </summary>
        [XmlElement("mall_url")]
        public string MallUrl { get; set; }
    }
}
