using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfcontractstatusSyncResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalSfcontractstatusSyncResponse : AopResponse
    {
        /// <summary>
        /// 结果对象
        /// </summary>
        [XmlElement("result")]
        public SalesForceContractStatusSyncResult Result { get; set; }
    }
}
