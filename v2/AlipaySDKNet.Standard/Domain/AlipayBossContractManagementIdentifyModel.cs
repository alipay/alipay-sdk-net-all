using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossContractManagementIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossContractManagementIdentifyModel : AopObject
    {
        /// <summary>
        /// 访问接口的来源（如：采购系统-ALI_PURCHASE_SYSTEM）
        /// </summary>
        [XmlElement("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 合约批次列表
        /// </summary>
        [XmlArray("contracts")]
        [XmlArrayItem("batch_info")]
        public List<BatchInfo> Contracts { get; set; }
    }
}
