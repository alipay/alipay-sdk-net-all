using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardAftersalesbreakcostModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardAftersalesbreakcostModifyModel : AopObject
    {
        /// <summary>
        /// 售后单id
        /// </summary>
        [XmlElement("aftersales_id")]
        public string AftersalesId { get; set; }

        /// <summary>
        /// 违约金金额，单位分，最大值取售后单上返回的违约金咨询结果，不收违约金传0
        /// </summary>
        [XmlElement("damages_cash")]
        public long DamagesCash { get; set; }
    }
}
