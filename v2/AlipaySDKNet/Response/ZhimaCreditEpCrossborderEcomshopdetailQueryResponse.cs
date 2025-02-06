using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCrossborderEcomshopdetailQueryResponse.
    /// </summary>
    public class ZhimaCreditEpCrossborderEcomshopdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果集
        /// </summary>
        [XmlElement("data")]
        public CrossBorderEcomShopDetail Data { get; set; }
    }
}
