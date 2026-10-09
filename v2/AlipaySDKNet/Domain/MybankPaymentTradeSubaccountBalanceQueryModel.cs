using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeSubaccountBalanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeSubaccountBalanceQueryModel : AopObject
    {
        /// <summary>
        /// 场景码，和开通子户时保持一致
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 子户外标
        /// </summary>
        [XmlElement("sub_card_no")]
        public string SubCardNo { get; set; }
    }
}
