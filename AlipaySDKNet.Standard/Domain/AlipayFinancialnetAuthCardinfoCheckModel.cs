using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthCardinfoCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthCardinfoCheckModel : AopObject
    {
        /// <summary>
        /// 是否校验卡bin
        /// </summary>
        [XmlElement("card_bin_check")]
        public bool CardBinCheck { get; set; }

        /// <summary>
        /// 可以传入明文卡号或者索引卡卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 信用卡的cvv2信息
        /// </summary>
        [XmlElement("cvv_2")]
        public string Cvv2 { get; set; }

        /// <summary>
        /// 是否更新卡信息明确传入true或不传,均执行更新
        /// </summary>
        [XmlElement("do_update")]
        public bool DoUpdate { get; set; }

        /// <summary>
        /// 信用卡的有效期
        /// </summary>
        [XmlElement("valid_date")]
        public string ValidDate { get; set; }
    }
}
