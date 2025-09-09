using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingPayinstUserBatchsendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingPayinstUserBatchsendModel : AopObject
    {
        /// <summary>
        /// 用户信息列表
        /// </summary>
        [XmlArray("user_list")]
        [XmlArrayItem("pay_inst_user")]
        public List<PayInstUser> UserList { get; set; }
    }
}
