using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntProdpaasGrmcoreProgramQueryResponse.
    /// </summary>
    public class AntProdpaasGrmcoreProgramQueryResponse : AopResponse
    {
        /// <summary>
        /// 业管平台立项信息
        /// </summary>
        [XmlElement("result_data")]
        public GrmProjectInfoDTO ResultData { get; set; }
    }
}
