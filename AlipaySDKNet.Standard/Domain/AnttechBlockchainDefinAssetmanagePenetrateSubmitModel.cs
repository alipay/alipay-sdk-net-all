using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinAssetmanagePenetrateSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinAssetmanagePenetrateSubmitModel : AopObject
    {
        /// <summary>
        /// 具体提交功能所需的业务数据JSON
        /// </summary>
        [XmlElement("biz_params")]
        public string BizParams { get; set; }

        /// <summary>
        /// 业务提交所需使用的接口功能
        /// </summary>
        [XmlElement("function")]
        public string Function { get; set; }

        /// <summary>
        /// 系统幂等请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
