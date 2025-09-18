using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntProdpaasProductInspectionCompleteCallbackResponse.
    /// </summary>
    public class AntProdpaasProductInspectionCompleteCallbackResponse : AopResponse
    {
        /// <summary>
        /// 自检单据编号
        /// </summary>
        [XmlElement("quality_inspection_no")]
        public string QualityInspectionNo { get; set; }
    }
}
