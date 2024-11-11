using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardOpenCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardOpenCheckModel : AopObject
    {
        /// <summary>
        /// 卡类型，数组。
        /// </summary>
        [XmlArray("card_types")]
        [XmlArrayItem("string")]
        public List<string> CardTypes { get; set; }

        /// <summary>
        /// 商户二级类目code
        /// </summary>
        [XmlElement("mcc_code")]
        public string MccCode { get; set; }

        /// <summary>
        /// 是否需要代运营授权
        /// </summary>
        [XmlElement("need_auth")]
        public bool NeedAuth { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
