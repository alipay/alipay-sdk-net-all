using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalArtifactlistQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalArtifactlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务错误码
        /// </summary>
        [XmlElement("biz_error_code")]
        public string BizErrorCode { get; set; }

        /// <summary>
        /// 业务错误信息
        /// </summary>
        [XmlElement("biz_error_msg")]
        public string BizErrorMsg { get; set; }

        /// <summary>
        /// 业务是否成功
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 结果对象
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("query_ob_artifact_list_d_t_o")]
        public List<QueryObArtifactListDTO> Result { get; set; }
    }
}
