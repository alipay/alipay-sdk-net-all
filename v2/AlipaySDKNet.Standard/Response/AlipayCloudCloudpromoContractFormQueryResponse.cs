using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoContractFormQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoContractFormQueryResponse : AopResponse
    {
        /// <summary>
        /// 合同数据
        /// </summary>
        [XmlElement("data")]
        public RentContractViewVO Data { get; set; }
    }
}
