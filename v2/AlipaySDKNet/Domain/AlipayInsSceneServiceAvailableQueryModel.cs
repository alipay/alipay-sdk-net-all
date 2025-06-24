using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneServiceAvailableQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneServiceAvailableQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁服务合约编号
        /// </summary>
        [XmlElement("ser_contract_no")]
        public string SerContractNo { get; set; }
    }
}
