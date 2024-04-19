using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasInsuranceInstanceruleSaveResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasInsuranceInstanceruleSaveResponse : AopResponse
    {
        /// <summary>
        /// 规则保存结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
