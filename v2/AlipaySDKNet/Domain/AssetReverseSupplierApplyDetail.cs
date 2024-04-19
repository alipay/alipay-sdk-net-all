using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetReverseSupplierApplyDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AssetReverseSupplierApplyDetail : AopObject
    {
        /// <summary>
        /// ["发起未妥投的sn和物流信息1","发起未妥投的sn和物流信息2"]
        /// </summary>
        [XmlArray("express_sn_details")]
        [XmlArrayItem("asset_reverse_supplier_apply_express_sn_details")]
        public List<AssetReverseSupplierApplyExpressSnDetails> ExpressSnDetails { get; set; }

        /// <summary>
        /// 发起未妥投供应商id
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 发起未妥投的供应商id
        /// </summary>
        [XmlElement("supplier_pid")]
        public string SupplierPid { get; set; }

        /// <summary>
        /// 发起未妥投的仓库id
        /// </summary>
        [XmlElement("warehouse_id")]
        public string WarehouseId { get; set; }
    }
}
