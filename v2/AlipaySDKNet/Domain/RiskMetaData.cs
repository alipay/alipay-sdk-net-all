using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskMetaData Data Structure.
    /// </summary>
    [Serializable]
    public class RiskMetaData : AopObject
    {
        /// <summary>
        /// 对该条数据的操作类型，新增或删除。删除仅支持当前app_id下的数据。相同数据不会重复添加。
        /// </summary>
        [XmlElement("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// 当risk_meta_data_type = BLACK_ADDRESS时，key约定[province(省份), city(城市), district(区/县), address(详细地址)]。当risk_meta_data_type不为BLACK_ADDRESS时，传入具体的内容值。
        /// </summary>
        [XmlElement("risk_meta_data_content")]
        public string RiskMetaDataContent { get; set; }

        /// <summary>
        /// 传递的高风险数据类型格式
        /// </summary>
        [XmlElement("risk_meta_data_type")]
        public string RiskMetaDataType { get; set; }
    }
}
