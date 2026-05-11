using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServicepackageOrderstatusModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalServicepackageOrderstatusModifyResponse : AopResponse
    {
        /// <summary>
        /// 结果数据
        /// </summary>
        [XmlElement("operate_res")]
        public string OperateRes { get; set; }
    }
}
