using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServiceuserAccountDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServiceuserAccountDeleteModel : AopObject
    {
        /// <summary>
        /// 好大夫id
        /// </summary>
        [XmlElement("hdf_out_id")]
        public string HdfOutId { get; set; }
    }
}
