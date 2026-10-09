using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossContractManagementCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossContractManagementCancelModel : AopObject
    {
        /// <summary>
        /// 访问接口的来源（如：采购系统-ALI_PURCHASE_SYSTEM）
        /// </summary>
        [XmlElement("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 合约批次号
        /// </summary>
        [XmlElement("contract_batch_no")]
        public string ContractBatchNo { get; set; }
    }
}
