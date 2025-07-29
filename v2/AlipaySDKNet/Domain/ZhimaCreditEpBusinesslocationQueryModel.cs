using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpBusinesslocationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpBusinesslocationQueryModel : AopObject
    {
        /// <summary>
        /// 客户场景下授权码
        /// </summary>
        [XmlElement("auth_id")]
        public string AuthId { get; set; }

        /// <summary>
        /// 场景查询键。该产品下传入被查询企业的pid
        /// </summary>
        [XmlElement("business_key")]
        public string BusinessKey { get; set; }

        /// <summary>
        /// 产品编码。本接口下固定值BusinessLocationSearch
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
