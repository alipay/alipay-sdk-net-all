using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaoBaoEcomStoreResult Data Structure.
    /// </summary>
    [Serializable]
    public class TaoBaoEcomStoreResult : AopObject
    {
        /// <summary>
        /// 行政处罚（市监）信息列表
        /// </summary>
        [XmlArray("case_info_list")]
        [XmlArrayItem("pen_case_info")]
        public List<PenCaseInfo> CaseInfoList { get; set; }

        /// <summary>
        /// 电商店铺信息列表
        /// </summary>
        [XmlArray("ecom_shop_info")]
        [XmlArrayItem("tao_bao_ecom_store_info")]
        public List<TaoBaoEcomStoreInfo> EcomShopInfo { get; set; }

        /// <summary>
        /// 法人维度店铺指标数据
        /// </summary>
        [XmlElement("fr_shop_index_info")]
        public FrShopIndexInfo FrShopIndexInfo { get; set; }

        /// <summary>
        /// 失信被执行人信息列表
        /// </summary>
        [XmlArray("punish_break_list")]
        [XmlArrayItem("punish_break_info")]
        public List<PunishBreakInfo> PunishBreakList { get; set; }

        /// <summary>
        /// 被执行人信息列表
        /// </summary>
        [XmlArray("punished_list")]
        [XmlArrayItem("punished_info")]
        public List<PunishedInfo> PunishedList { get; set; }

        /// <summary>
        /// 法定代表人信息
        /// </summary>
        [XmlArray("ry_pos_fr_list")]
        [XmlArrayItem("related_performance_info")]
        public List<RelatedPerformanceInfo> RyPosFrList { get; set; }
    }
}
