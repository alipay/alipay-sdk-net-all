using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentDeductInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentDeductInfoDTO : AopObject
    {
        /// <summary>
        /// 代扣签约场景。租赁代扣固定传入RENT_DEDUCT
        /// </summary>
        [XmlElement("sign_scene")]
        public string SignScene { get; set; }
    }
}
