using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseBillAcceptanceSyncResponse.
    /// </summary>
    public class AnttechOceanbaseBillAcceptanceSyncResponse : AopResponse
    {
        /// <summary>
        /// success字段写入失败为false时，需要通过errorMsg返回失败原因
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }
    }
}
