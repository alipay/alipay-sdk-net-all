using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandProductionOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandProductionOrderSyncModel : AopObject
    {
        /// <summary>
        /// 总数（该项目单下达到产线的总数）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 幂等批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 下产线的物料ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 项目单号（供应商下产线的维度）
        /// </summary>
        [XmlElement("project_no")]
        public string ProjectNo { get; set; }

        /// <summary>
        /// 区域仓code
        /// </summary>
        [XmlElement("regional_warehouse")]
        public string RegionalWarehouse { get; set; }

        /// <summary>
        /// 项目单下的指令明细信息,长度限制为3000, 传100个指令ID，格式按照附录6.13约定.
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
