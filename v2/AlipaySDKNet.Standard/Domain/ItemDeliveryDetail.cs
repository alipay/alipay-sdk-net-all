using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemDeliveryDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDeliveryDetail : AopObject
    {
        /// <summary>
        /// 已生产数量, 分批反馈时候必传.
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 订单明细ID
        /// </summary>
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 由供应商自定义的分批反馈批次号，用于保持幂等，此值不传则需要按整批反馈.(由字母,数字,下划线组成)
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 物料版本信息
        /// </summary>
        [XmlElement("item_version_info")]
        public AssetItemVersion ItemVersionInfo { get; set; }

        /// <summary>
        /// 物流公司code, 比如: SF-顺丰, POST-中国邮政, CAINIAO-菜鸟.
        /// </summary>
        [XmlElement("logistic_code")]
        public string LogisticCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [XmlElement("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 物流订单号
        /// </summary>
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 选配物料信息
        /// </summary>
        [XmlArray("optional_item_infos")]
        [XmlArrayItem("optional_item_info")]
        public List<OptionalItemInfo> OptionalItemInfos { get; set; }

        /// <summary>
        /// 供应商传入库存动销明细对应的凭证日期
        /// </summary>
        [XmlElement("voucher_time")]
        public string VoucherTime { get; set; }
    }
}
