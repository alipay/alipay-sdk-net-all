using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalGuessaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalGuessaskQueryModel : AopObject
    {
        /// <summary>
        /// 好大夫用户id
        /// </summary>
        [XmlElement("hdf_user_id")]
        public string HdfUserId { get; set; }

        /// <summary>
        /// 病例返回条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
