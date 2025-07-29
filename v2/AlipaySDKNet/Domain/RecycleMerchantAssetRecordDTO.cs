using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleMerchantAssetRecordDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleMerchantAssetRecordDTO : AopObject
    {
        /// <summary>
        /// 流水金额，单位：分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 商户资产类型
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 订单号，与交易相关
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 流水id，保证是唯一的
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 流水状态
        /// </summary>
        [XmlElement("record_status")]
        public string RecordStatus { get; set; }

        /// <summary>
        /// 流水类型
        /// </summary>
        [XmlElement("record_type")]
        public string RecordType { get; set; }
    }
}
