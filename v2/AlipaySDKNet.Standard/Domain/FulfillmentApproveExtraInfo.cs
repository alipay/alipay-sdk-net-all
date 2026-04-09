using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FulfillmentApproveExtraInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentApproveExtraInfo : AopObject
    {
        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }
    }
}
