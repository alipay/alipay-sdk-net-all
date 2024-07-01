using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletBillstatusQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseWalletBillstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 出账状态
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
