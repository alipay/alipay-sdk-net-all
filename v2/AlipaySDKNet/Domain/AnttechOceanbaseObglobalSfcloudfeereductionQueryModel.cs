using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfcloudfeereductionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalSfcloudfeereductionQueryModel : AopObject
    {
        /// <summary>
        /// 券申请id
        /// </summary>
        [XmlElement("cloud_fee_reduction_id")]
        public string CloudFeeReductionId { get; set; }

        /// <summary>
        /// salesforce唯一id
        /// </summary>
        [XmlElement("salesforce_id")]
        public string SalesforceId { get; set; }
    }
}
