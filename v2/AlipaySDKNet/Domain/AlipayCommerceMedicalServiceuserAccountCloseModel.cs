using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServiceuserAccountCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServiceuserAccountCloseModel : AopObject
    {
        /// <summary>
        /// 外部ID加密值
        /// </summary>
        [XmlElement("hdf_out_id")]
        public string HdfOutId { get; set; }
    }
}
