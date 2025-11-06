using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerPointbalanceQueryResponse.
    /// </summary>
    public class ZhimaCustomerPointbalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 芝麻粒余额
        /// </summary>
        [XmlElement("point_balance")]
        public long PointBalance { get; set; }
    }
}
