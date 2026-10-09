using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandQualityAssetproduceDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandQualityAssetproduceDetectModel : AopObject
    {
        /// <summary>
        /// 供应商传入本次品检的物料数量(单位是个)，系统对数量做正确性校验
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 当品检类型为 生产品检的时候，供应商传入生产指令ID，传入后会对该生产指令ID真实性做存在性的校验 当品检类型为 仓发品检的时候，为配送指令
        /// </summary>
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 时间戳，nfc_detect_type = NFC_DETECT_DELIVERY 时必填，精度为秒级的10位UTC时间
        /// </summary>
        [XmlElement("delivery_time")]
        public long DeliveryTime { get; set; }

        /// <summary>
        /// 发货物流单号，nfc_detect_type = NFC_DETECT_DELIVERY 时必填
        /// </summary>
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 不传默认生产品检 NFC_DETECT_PRODUCE，传 NFC_DETECT_DELIVERY 仓发品检
        /// </summary>
        [XmlElement("nfc_detect_type")]
        public string NfcDetectType { get; set; }

        /// <summary>
        /// 品检详情信息，其中有唯一序号代表实体物料，有品检的内容项代表需要品检的具体内容
        /// </summary>
        [XmlArray("quality_detect_detail")]
        [XmlArrayItem("quality_detect_detail")]
        public List<QualityDetectDetail> QualityDetectDetail { get; set; }
    }
}
