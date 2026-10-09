using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationTestOpenapiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationTestOpenapiQueryModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 金额为元
        /// </summary>
        [XmlElement("price_a")]
        public string PriceA { get; set; }

        /// <summary>
        /// ,微信，
        /// </summary>
        [XmlElement("test_b")]
        public string TestB { get; set; }

        /// <summary>
        /// json
        /// </summary>
        [XmlElement("test_c")]
        public string TestC { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("u_test")]
        public string UTest { get; set; }
    }
}
