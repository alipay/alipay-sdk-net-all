using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfinspectionCompleteResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfinspectionCompleteResponse : AopResponse
    {
        /// <summary>
        /// hdf检验检查单号
        /// </summary>
        [XmlElement("hdf_check_no")]
        public string HdfCheckNo { get; set; }
    }
}
