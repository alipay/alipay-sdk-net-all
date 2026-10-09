using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockOpenUseridQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockOpenUseridQueryModel : AopObject
    {
        /// <summary>
        /// 用户证券签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }
    }
}
