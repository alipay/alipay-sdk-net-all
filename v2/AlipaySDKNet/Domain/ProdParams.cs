using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProdParams Data Structure.
    /// </summary>
    [Serializable]
    public class ProdParams : AopObject
    {
        /// <summary>
        /// 预授权业务信息
        /// </summary>
        [XmlElement("auth_biz_params")]
        public string AuthBizParams { get; set; }

        /// <summary>
        /// 前置营销信息，由商户接入前置收银台后生成，在拉起独立签约时传递
        /// </summary>
        [XmlElement("pay_operation_info")]
        public string PayOperationInfo { get; set; }

        /// <summary>
        /// 前置收银id，商户接入前置收银台咨询时生成
        /// </summary>
        [XmlElement("pre_consult_id")]
        public string PreConsultId { get; set; }
    }
}
