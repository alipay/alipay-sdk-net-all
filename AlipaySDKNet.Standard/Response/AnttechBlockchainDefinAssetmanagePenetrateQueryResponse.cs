using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinAssetmanagePenetrateQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinAssetmanagePenetrateQueryResponse : AopResponse
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
        /// 业务查询返回数据JSON，一般为各类申请的状态，内容等，资产穿透类查询不返回个人信息
        /// </summary>
        [XmlElement("result_obj")]
        public string ResultObj { get; set; }
    }
}
