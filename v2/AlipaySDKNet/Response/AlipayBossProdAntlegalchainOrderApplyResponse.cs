using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlegalchainOrderApplyResponse.
    /// </summary>
    public class AlipayBossProdAntlegalchainOrderApplyResponse : AopResponse
    {
        /// <summary>
        /// 法链业务ID,用于查询上链状态
        /// </summary>
        [XmlElement("bas_data_id")]
        public string BasDataId { get; set; }
    }
}
