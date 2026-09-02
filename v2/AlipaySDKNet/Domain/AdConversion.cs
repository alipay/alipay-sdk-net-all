using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdConversion Data Structure.
    /// </summary>
    [Serializable]
    public class AdConversion : AopObject
    {
        /// <summary>
        /// 资产类型代码(asset)。标识广告投放在哪个端/载体
        /// </summary>
        [XmlElement("asset_type_code")]
        public string AssetTypeCode { get; set; }

        /// <summary>
        /// 资产类型名称
        /// </summary>
        [XmlElement("asset_type_name")]
        public string AssetTypeName { get; set; }

        /// <summary>
        /// 转化id
        /// </summary>
        [XmlElement("conversion_id")]
        public string ConversionId { get; set; }

        /// <summary>
        /// 转化事件名称
        /// </summary>
        [XmlElement("conversion_name_show")]
        public string ConversionNameShow { get; set; }

        /// <summary>
        /// 接入方式名称
        /// </summary>
        [XmlElement("conversion_raw_data_type_name")]
        public string ConversionRawDataTypeName { get; set; }

        /// <summary>
        /// 转化类型代码(converted_event)。标识一次具体转化行为的业务类型（如表单提交、下单、加购)
        /// </summary>
        [XmlElement("conversion_type_code")]
        public string ConversionTypeCode { get; set; }

        /// <summary>
        /// 转化事件名称
        /// </summary>
        [XmlElement("conversion_type_name")]
        public string ConversionTypeName { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 转化窗口
        /// </summary>
        [XmlElement("join_window_name")]
        public AdConversionJoinWindow JoinWindowName { get; set; }
    }
}
