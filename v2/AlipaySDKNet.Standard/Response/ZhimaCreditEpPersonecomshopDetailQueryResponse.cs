using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpPersonecomshopDetailQueryResponse.
    /// </summary>
    public class ZhimaCreditEpPersonecomshopDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果集
        /// </summary>
        [XmlElement("data")]
        public TaoBaoEcomStoreResult Data { get; set; }
    }
}
