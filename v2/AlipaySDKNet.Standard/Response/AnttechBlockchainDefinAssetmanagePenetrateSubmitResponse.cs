using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinAssetmanagePenetrateSubmitResponse.
    /// </summary>
    public class AnttechBlockchainDefinAssetmanagePenetrateSubmitResponse : AopResponse
    {
        /// <summary>
        /// 业务错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 业务展示类信息
        /// </summary>
        [XmlElement("error_view_msg")]
        public string ErrorViewMsg { get; set; }

        /// <summary>
        /// 业务提交返回数据JSON，一般为业务类编号，成功与否等信息
        /// </summary>
        [XmlElement("result_obj")]
        public string ResultObj { get; set; }
    }
}
