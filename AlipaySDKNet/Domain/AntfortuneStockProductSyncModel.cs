using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockProductSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockProductSyncModel : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extension")]
        public Kv Extension { get; set; }

        /// <summary>
        /// 库存状态； FULL - 充足，TIGHT - 即将售罄，SOLD_OUT - 售罄
        /// </summary>
        [XmlElement("inventory_state")]
        public string InventoryState { get; set; }

        /// <summary>
        /// 机构定义的产品代码
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 产品类型；ELN - 收益凭证
        /// </summary>
        [XmlElement("prod_type")]
        public string ProdType { get; set; }

        /// <summary>
        /// 库存剩余金额
        /// </summary>
        [XmlElement("remain_inventory_amt")]
        public string RemainInventoryAmt { get; set; }

        /// <summary>
        /// 库存剩余人数
        /// </summary>
        [XmlElement("remain_inventory_num")]
        public long RemainInventoryNum { get; set; }
    }
}
