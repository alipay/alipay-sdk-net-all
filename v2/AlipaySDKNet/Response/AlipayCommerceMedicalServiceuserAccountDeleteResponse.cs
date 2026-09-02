using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServiceuserAccountDeleteResponse.
    /// </summary>
    public class AlipayCommerceMedicalServiceuserAccountDeleteResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("orderStr")]
        public string OrderStr { get; set; }
    }
}
