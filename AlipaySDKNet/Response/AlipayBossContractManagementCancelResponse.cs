using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossContractManagementCancelResponse.
    /// </summary>
    public class AlipayBossContractManagementCancelResponse : AopResponse
    {
        /// <summary>
        /// 撤销操作提示
        /// </summary>
        [XmlElement("result_set")]
        public string ResultSet { get; set; }
    }
}
