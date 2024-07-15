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
        /// risk_meta_data_type = BLACK_ADDRESS时，按照标准格式传入[province(省份), city(城市), district(区/县), address(详细地址)]四组值； risk_meta_data_type=BLACK_MOBILE, 传入手机号； risk_meta_data_type=BLACK_CERT_NO,传入身份证号； risk_meta_data_type=BLACK_ALIPAY_USER_ID,传入支付宝userId； risk_meta_data_type=BLACK_MOBILE_SHA256,传入手机号sha256值； risk_meta_data_type=BLACK_CERT_NO_SHA256,传入身份证号sha256值。
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
