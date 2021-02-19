using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettlePaycontractQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettlePaycontractQueryModel : AopObject
    {
        /// <summary>
        /// 查询条件
        /// </summary>
        [XmlElement("pay_contract_base_dto")]
        public PayContractBaseDTO PayContractBaseDto { get; set; }
    }
}
