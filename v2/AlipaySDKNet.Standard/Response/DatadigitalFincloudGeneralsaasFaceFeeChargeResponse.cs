using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceFeeChargeResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasFaceFeeChargeResponse : AopResponse
    {
        /// <summary>
        /// 成功时返回success，失败时接口会报错
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
