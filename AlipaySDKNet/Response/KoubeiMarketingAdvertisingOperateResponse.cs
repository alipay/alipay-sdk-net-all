using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingAdvertisingOperateResponse.
    /// </summary>
    public class KoubeiMarketingAdvertisingOperateResponse : AopResponse
    {
        /// <summary>
        /// 正常操作返回当前操作的广告id。如果操作失败，返回的广告id为空
        /// </summary>
        [XmlElement("ad_id")]
        public string AdId { get; set; }
    }
}
