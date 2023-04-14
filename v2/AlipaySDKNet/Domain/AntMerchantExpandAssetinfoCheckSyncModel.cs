using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetinfoCheckSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetinfoCheckSyncModel : AopObject
    {
        /// <summary>
        /// 批次号，标示这一批次
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 检测明细
        /// </summary>
        [XmlArray("check_details")]
        [XmlArrayItem("check_details")]
        public List<CheckDetails> CheckDetails { get; set; }

        /// <summary>
        /// 检测阶段代码
        /// </summary>
        [XmlElement("check_phase")]
        public string CheckPhase { get; set; }

        /// <summary>
        /// 检测阶段的状态
        /// </summary>
        [XmlElement("check_status")]
        public string CheckStatus { get; set; }

        /// <summary>
        /// 和机器绑定的供应商ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 校验类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
