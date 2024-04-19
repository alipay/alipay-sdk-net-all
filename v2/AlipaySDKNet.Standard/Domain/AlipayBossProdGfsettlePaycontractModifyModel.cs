using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdGfsettlePaycontractModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdGfsettlePaycontractModifyModel : AopObject
    {
        /// <summary>
        /// 修改的付款条款信息
        /// </summary>
        [XmlElement("paycontract")]
        public PayContractDTO Paycontract { get; set; }
    }
}
