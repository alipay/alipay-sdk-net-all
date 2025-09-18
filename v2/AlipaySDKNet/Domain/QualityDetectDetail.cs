using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QualityDetectDetail Data Structure.
    /// </summary>
    [Serializable]
    public class QualityDetectDetail : AopObject
    {
        /// <summary>
        /// 线圈烧录的UTC时间戳
        /// </summary>
        [XmlElement("burning_time_stamp")]
        public long BurningTimeStamp { get; set; }

        /// <summary>
        /// 品检详情信息，其中每个key代表需要品检的字段，value则是供应商品检过程中识别到的物料实体信息值
        /// </summary>
        [XmlElement("detect_detail")]
        public string DetectDetail { get; set; }

        /// <summary>
        /// 动态NFC链接，由MCU生成，基于静态链接和时间戳的动态加密算法拼接而成，每次NFC碰起来的链接都不一样
        /// </summary>
        [XmlElement("dynamic_nfc_url")]
        public string DynamicNfcUrl { get; set; }

        /// <summary>
        /// 参数是NFC链接，由支付宝平台下发，品检时供应商须回传该链接
        /// </summary>
        [XmlElement("nfc_url")]
        public string NfcUrl { get; set; }

        /// <summary>
        /// 当前UTC时间戳
        /// </summary>
        [XmlElement("quality_time_stamp")]
        public long QualityTimeStamp { get; set; }

        /// <summary>
        /// 参数代表实体物料的唯一标识，平台将每个物料通过该字段进行区分，下发给供应商，供应商品检是需要将该字段上传用以物料实体的识别
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
