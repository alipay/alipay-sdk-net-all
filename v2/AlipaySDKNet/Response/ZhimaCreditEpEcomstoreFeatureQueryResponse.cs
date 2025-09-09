using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpEcomstoreFeatureQueryResponse.
    /// </summary>
    public class ZhimaCreditEpEcomstoreFeatureQueryResponse : AopResponse
    {
        /// <summary>
        /// 电商店铺特征信息
        /// </summary>
        [XmlElement("data")]
        public EcomStoreFeatureInfo Data { get; set; }
    }
}
