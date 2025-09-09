using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpEcomstoreDetailQueryResponse.
    /// </summary>
    public class ZhimaCreditEpEcomstoreDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 电商店铺明细数据
        /// </summary>
        [XmlElement("data")]
        public EcomStoreInfo Data { get; set; }
    }
}
