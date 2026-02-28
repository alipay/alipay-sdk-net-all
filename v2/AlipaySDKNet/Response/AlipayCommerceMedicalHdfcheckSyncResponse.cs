using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfcheckSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfcheckSyncResponse : AopResponse
    {
        /// <summary>
        /// hdf申请单号
        /// </summary>
        [XmlElement("hdf_check_no")]
        public string HdfCheckNo { get; set; }
    }
}
