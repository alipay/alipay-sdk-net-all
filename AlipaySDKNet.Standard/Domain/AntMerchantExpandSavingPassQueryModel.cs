using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandSavingPassQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandSavingPassQueryModel : AopObject
    {
        /// <summary>
        /// 咨询来源渠道
        /// </summary>
        [XmlElement("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 解决方案code ，如省卡付费会员
        /// </summary>
        [XmlElement("sol_code")]
        public string SolCode { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
