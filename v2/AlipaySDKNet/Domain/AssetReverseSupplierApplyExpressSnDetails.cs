using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetReverseSupplierApplyExpressSnDetails Data Structure.
    /// </summary>
    [Serializable]
    public class AssetReverseSupplierApplyExpressSnDetails : AopObject
    {
        /// <summary>
        /// 未妥投申请数量，无SN未妥投时必传
        /// </summary>
        [XmlElement("apply_count")]
        public string ApplyCount { get; set; }

        /// <summary>
        /// 逆向退回的物料明细：后续供应商收货拆包后直接扫描品条码，若判断品名有sn则需仓库进行sn信息反馈
        /// </summary>
        [XmlArray("asset_reverse_item_details")]
        [XmlArrayItem("asset_reverse_item_detail")]
        public List<AssetReverseItemDetail> AssetReverseItemDetails { get; set; }

        /// <summary>
        /// 物流信息
        /// </summary>
        [XmlElement("logistics_infos")]
        public LogisticsInfo LogisticsInfos { get; set; }

        /// <summary>
        /// sn列表
        /// </summary>
        [XmlArray("sn_records")]
        [XmlArrayItem("string")]
        public List<string> SnRecords { get; set; }
    }
}
