using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedicineSpuModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedicineSpuModifyModel : AopObject
    {
        /// <summary>
        /// 药品标品信息
        /// </summary>
        [XmlElement("spu")]
        public MedicineSpu Spu { get; set; }
    }
}
